using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.Helpers;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Services
{
    public class TourService : ITourService
    {
        private readonly ApplicationDbContext _context;
        private readonly ITourRepository _tourRepository;
        private readonly ITourPackageRepository _tourPackageRepository;
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IVoucherRepository _voucherRepository;
        private readonly IUserRepository _userRepository;
        public TourService(ApplicationDbContext context,
            ITourRepository tourRepository,
            ITourPackageRepository tourPackageRepository,
            IScheduleRepository scheduleReposity,
            IVoucherRepository voucherService,
            IUserRepository userRepository
            )
        {
            _context = context;
            _tourRepository = tourRepository;
            _tourPackageRepository = tourPackageRepository;
            _scheduleRepository = scheduleReposity;
            _voucherRepository = voucherService;
            _userRepository = userRepository;
        }

        public async Task<IActionResult> CreateTourWithPackageAsync(CreateTourWithPackageDTO dto)
        {
            try
            {
                var user = await _userRepository.FindByIdAsync(dto.UserId);

                if (user == null)
                {
                    return new NotFoundObjectResult("User not found");
                }

                var tour = dto.TourDTO.ToTour();
                tour.User = user;
                await _tourRepository.AddAsync(tour);

                var packages = new List<TourPackage>();
                foreach (var packageDto in dto.CreatePackageDTO)
                {
                    var package = packageDto.ToPackage();
                    package.Tour = tour;

                    var newShedules = new List<Schedule>();
                    if (package.Schedules != null)
                    {
                        foreach (var schedule in package.Schedules)
                        {
                            schedule.TourPackage = package;
                            newShedules.Add(schedule);
                        }
                        await _scheduleRepository.AddRangeAsync(newShedules);
                    }

                    var newVouchers = new List<Voucher>();
                    if (package.Vouchers != null)
                    {
                        foreach (var voucher in package.Vouchers)
                        {
                            voucher.TourPackage = package;
                            newVouchers.Add(voucher);
                        }
                        await _voucherRepository.AddRangeAsync(newVouchers);
                    }

                    packages.Add(package);
                }

                await _tourPackageRepository.AddRangeAsync(packages);

                await _tourRepository.SaveChangesAsync();

                return new OkObjectResult("Create success");
            }
            catch (DbUpdateException dbEx)
            {
                return new BadRequestObjectResult($"An error occurred while saving the entity changes: {dbEx.InnerException?.Message ?? dbEx.Message}");
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }

        public async Task<IActionResult> DeltedAsync(int id)
        {
            try
            {
                var tour = await _tourRepository.FindByIdAsync(id);

                if (tour == null)
                {
                    return new NotFoundObjectResult("Tour not found");
                }

                _tourRepository.RemoveAsync(tour);
                await _tourRepository.SaveChangesAsync();

                return new OkObjectResult("Delete success");
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }

        public async Task<List<TourDTO>> GetAllAsync(int page, int pageSize, QueryTour query)
        {
            var tours = _tourRepository.FindAll();
            tours = tours.Skip((page - 1) * pageSize)
                .Take(pageSize);

            if (!string.IsNullOrWhiteSpace(query.region))
            {
                tours = tours.Where(x => x.Region.ToLower() == query.region.ToLower());
            }

            if (!string.IsNullOrWhiteSpace(query.searchQuery))
            {
                tours = tours.Where(x => x.Name.ToLower().Contains(query.searchQuery.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(query.searchBy))
            {
                switch (query.searchBy.ToLower())
                {
                    case "name":
                        tours = tours.Where(t => t.Name.ToLower().Contains(query.searchBy.ToLower()));
                        break;
                    case "city":
                        tours = tours.Where(t => t.City.ToLower().Contains(query.searchBy.ToLower()));
                        break;
                    case "country":
                        tours = tours.Where(t => t.Country.ToLower().Contains(query.searchBy.ToLower()));
                        break;
                }
            }

            if (!string.IsNullOrWhiteSpace(query.sortBy))
            {
                switch (query.sortBy.ToLower())
                {
                    case "price_desc":
                        tours = tours.OrderByDescending(t => t.Opening);
                        break;
                    case "price_asc":
                        tours = tours.OrderBy(t => t.Opening);
                        break;
                }
            }

            return await tours.Select(t => t.ToTourDto()).ToListAsync();
        }

        public async Task<TourDTO?> GetTourByIdAsync(int id)
        {
            var tour = await _tourRepository.FindByIdAsync(id);

            return tour?.ToTourDetailDto();
        }

        public async Task<IActionResult> RestoreAsync(int id)
        {
            try
            {
                var tour = await _tourRepository.FindByIdAsync(id);

                if (tour == null)
                {
                    return new NotFoundObjectResult("Tour not found");
                }

                tour.IsDeleted = false;
                await _tourRepository.SaveChangesAsync();

                return new OkObjectResult("Restore success");
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
        public async Task<IActionResult> SoftDeleteAsync(int id)
        {
            try
            {
                var tour = await _tourRepository.FindByIdAsync(id);

                if (tour == null)
                {
                    return new NotFoundObjectResult("Tour not found");
                }

                tour.IsDeleted = true;
                await _tourRepository.SaveChangesAsync();

                return new OkObjectResult("Delete success");

            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}
