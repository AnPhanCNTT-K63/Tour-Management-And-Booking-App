using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.Helpers;
using TravelWebBackEndCore.Interfaces;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repository
{
    public class TourRepository : ITourRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IScheduleReposity _scheduleReposity;
        private readonly IVoucherRepository _voucherRepository;
        public TourRepository(ApplicationDbContext context, IScheduleReposity scheduleReposity, IVoucherRepository voucherRepository)
        {
            _context = context;
            _scheduleReposity = scheduleReposity;
            _voucherRepository = voucherRepository;
        }

        public async Task<string> CreateTourWithPackageAsync(CreateTourWithPackageDTO dto)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == dto.UserId);

                if (user == null)
                {
                    return "User not found";
                }

                var tour = dto.TourDTO.ToTour();
                tour.User = user;
                await _context.Tours.AddAsync(tour);

                var packages = new List<TourPackage>();
                foreach (var packageDto in dto.CreatePackageDTO)
                {
                    var package = packageDto.ToPackage();
                    package.Tour = tour;

                    if (package.Schedules != null)
                    {
                        await _scheduleReposity.AddRangeSchedulesAsync(package.Schedules, package);
                    }

                    if (package.Vouchers != null)
                    {
                        await _voucherRepository.AddRangeVouchersAsync(package.Vouchers, package);
                    }

                    packages.Add(package);
                }

                await _context.TourPackages.AddRangeAsync(packages);

                var flag = await _context.SaveChangesAsync();

                return flag > 0 ? "Create success" : "Create failure";
            }
            catch (DbUpdateException dbEx)
            {
                return $"An error occurred while saving the entity changes: {dbEx.InnerException?.Message ?? dbEx.Message}";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public async Task<string> DeltedAsync(int id)
        {
            try
            {
                var tour = await _context.Tours.FindAsync(id);

                if (tour == null)
                {
                    return "Tour not found";
                }

                _context.Tours.Remove(tour);
                await _context.SaveChangesAsync();

                return "Delete success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public async Task<List<TourDTO>> GetAllAsync(QueryTour query)
        {
            var tours = _context.Tours
            .Select(t => t.ToTourDto())
            .AsQueryable();

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


            return await tours.ToListAsync();

        }

        public async Task<TourDTO?> GetTourByIdAsync(int id)
        {
            var tour = await _context.Tours.Include(t => t.TourPackages).FirstOrDefaultAsync(t => t.Id == id);

            return tour?.ToTourDetailDto();
        }

        public async Task<string> RestoreAsynce(int id)
        {
            try
            {
                var tour = await _context.Tours.FindAsync(id);

                if (tour == null)
                {
                    return "Tour not found";
                }

                tour.IsDeleted = false;
                await _context.SaveChangesAsync();

                return "Restore success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public async Task<string> SoftDeleteAsync(int id)
        {
            try
            {
                var tour = await _context.Tours.FindAsync(id);

                if (tour == null)
                {
                    return "Tour not found";
                }

                tour.IsDeleted = true;
                await _context.SaveChangesAsync();

                return "Delete success";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }



    }
}
