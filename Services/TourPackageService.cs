using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;
using TravelWebBackEndCore.Repositories;

namespace TravelWebBackEndCore.Services
{
    public class TourPackageService : ITourPackageService
    {
        private readonly ITourPackageRepository _tourPackageRepository;
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IVoucherRepository _voucherRepository;
        private readonly ITourRepository _tourRepository;
        public TourPackageService(ApplicationDbContext context,
            IScheduleRepository scheduleReposity,
            IVoucherRepository voucherRepository,
            ITourPackageRepository tourPackageRepository,
            ITourRepository tourRepository
            )
        {
            _scheduleRepository = scheduleReposity;
            _voucherRepository = voucherRepository;
            _tourPackageRepository = tourPackageRepository;
            _tourRepository = tourRepository;
        }

        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                var package = await _tourPackageRepository.FindByIdAsync(id);

                if (package == null)
                {
                    return new NotFoundObjectResult("Package not found");
                }

                _tourPackageRepository.RemoveAsync(package);
                await _tourPackageRepository.SaveChangesAsync();
                return new OkObjectResult("Package deleted successfully");

            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex.Message);
            }
        }

        public async Task<PackageDTO?> GetById(int id)
        {
            var package = await _tourPackageRepository.GetTourPackageWithDetailsAsync(id);

            if (package == null)
            {
                return null;
            }

            return package.ToPackageDto();

        }

        public async Task<List<PackageDTO>?> GetByTourId(int tour_id)
        {
            try
            {
                var tour = _tourRepository.FindByIdAsync(tour_id);

                if (tour == null)
                {
                    return null;
                }

                var packages = _tourPackageRepository.GetTourPackageDetailsByTourIdAsync(tour_id);

                return await packages.Select(p => p.ToPackageDto()).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IActionResult> UpdateAsync(int id, UpdatePackageDTO packageDTO)
        {
            try
            {
                var package = await _tourPackageRepository.GetTourPackageWithDetailsAsync(id);

                if (package == null)
                {
                    return new NotFoundObjectResult("Package not found");
                }

                package.UpdatedAt = DateTime.UtcNow;

                package.Name = packageDTO.Name;
                package.Description = packageDTO.Description;
                package.Image = packageDTO.Image;
                package.Price = packageDTO.Price;
                package.Activities = packageDTO.Activities;
                package.IsChangeSchedule = packageDTO.IsChangeSchedule;
                package.IsRefund = packageDTO.IsRefund;
                package.CheckIn = packageDTO.CheckIn;
                package.VAT = packageDTO.VAT;
                package.Quantity = packageDTO.Quantity;

                if (packageDTO.Schedules != null)
                {
                    var incomingScheduleIds = packageDTO.Schedules.Select(s => s.Id).ToList();
                    var schedulesToRemove = package.Schedules?
                        .Where(s => !incomingScheduleIds.Contains(s.Id))
                        .ToList() ?? new List<Schedule>();

                    if (schedulesToRemove.Count > 0)
                        _scheduleRepository.RemoveSchedules(schedulesToRemove);

                    var newSchedules = new List<Schedule>();

                    foreach (var scheduleDTO in packageDTO.Schedules)
                    {
                        var existingSchedule = package.Schedules?.FirstOrDefault(s => s.Id == scheduleDTO.Id);
                        if (existingSchedule != null)
                        {
                            existingSchedule.TravelDay = scheduleDTO.TravelDay;
                        }
                        else
                        {
                            var newSchedule = new CreateScheduleDTO
                            {
                                TravelDay = scheduleDTO.TravelDay
                            };
                            var addSchedule = newSchedule.ToSchedule();
                            addSchedule.TourPackage = package;

                            newSchedules.Add(addSchedule);
                        }
                    }

                    if (newSchedules.Any())
                    {
                        await _scheduleRepository.AddRangeAsync(newSchedules);
                    }
                }

                var newVouchers = new List<Voucher>();
                if (packageDTO.Vouchers != null)
                {
                    var incomingVoucherIds = packageDTO.Vouchers.Select(s => s.Id).ToList();
                    var vouchersToRemove = package.Vouchers?
                        .Where(s => !incomingVoucherIds.Contains(s.Id))
                        .ToList() ?? new List<Voucher>();

                    if (vouchersToRemove.Count > 0)
                        _voucherRepository.RemoveVouchers(vouchersToRemove);

                    foreach (var voucherDTO in packageDTO.Vouchers)
                    {
                        var existingVoucher = package.Vouchers?.FirstOrDefault(s => s.Id == voucherDTO.Id);
                        if (existingVoucher != null)
                        {
                            existingVoucher.Discount = voucherDTO.Discount;
                            existingVoucher.Title = voucherDTO.Title;
                            existingVoucher.Code = voucherDTO.Code;
                        }
                        else
                        {
                            var newVoucher = new CreateVoucherDTO
                            {
                                Discount = voucherDTO.Discount,
                                Title = voucherDTO.Title,
                                Code = voucherDTO.Code,

                            };
                            var addVoucher = newVoucher.ToVoucher();
                            addVoucher.TourPackage = package;

                            newVouchers.Add(addVoucher);
                        }
                    }
                    if (newVouchers.Any())
                    {
                        await _voucherRepository.AddRangeAsync(newVouchers);
                    }
                }

                await _tourPackageRepository.SaveChangesAsync();
                return new OkObjectResult("Package updated successfully");

            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(e.Message);
            }
        }
    }
}
