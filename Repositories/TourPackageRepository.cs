using Microsoft.EntityFrameworkCore;
using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Interfaces;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class TourPackageRepository : ITourPackageRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IScheduleReposity _scheduleReposity;
        private readonly IVoucherRepository _voucherRepository;
        public TourPackageRepository(ApplicationDbContext context, IScheduleReposity scheduleReposity, IVoucherRepository voucherRepository)
        {
            _context = context;
            _scheduleReposity = scheduleReposity;
            _voucherRepository = voucherRepository;
        }

        public async Task<string> DeleteAsync(int id)
        {
            try
            {
                var package = await _context.TourPackages.FindAsync(id);

                if (package == null)
                {
                    return "Package not found";
                }

                _context.TourPackages.Remove(package);
                await _context.SaveChangesAsync();
                return "Package deleted successfully";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<PackageDTO?> GetById(int id)
        {
            var package = await _context.TourPackages.Include(p => p.Schedules).Include(p => p.Vouchers).FirstOrDefaultAsync(p => p.Id == id);

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
                var tour = await _context.Tours.FindAsync(tour_id);

                if (tour == null)
                {
                    return null;
                }

                var packages = _context.TourPackages
                    .Include(p => p.Schedules)
                    .Include(p => p.Vouchers)
                    .Where(p => p.TourId == tour_id);

                return await packages.Select(p => p.ToPackageDto()).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<string> UpdateAsync(int id, UpdatePackageDTO packageDTO)
        {
            try
            {
                var package = await _context.TourPackages
                    .Include(p => p.Schedules)
                    .Include(p => p.Vouchers)
                    .FirstOrDefaultAsync(p => p.Id == id);

                if (package == null)
                {
                    return "Package not found";
                }

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
                        _scheduleReposity.RemoveSchedules(schedulesToRemove);

                    foreach (var scheduleDTO in packageDTO.Schedules)
                    {
                        var existingSchedule = package.Schedules?.FirstOrDefault(s => s.Id == scheduleDTO.Id);
                        if (existingSchedule != null)
                        {
                            _scheduleReposity.UpdateSchedule(existingSchedule, scheduleDTO);
                        }
                        else
                        {
                            var newSchedule = new CreateScheduleDTO
                            {
                                TravelDay = scheduleDTO.TravelDay
                            };
                            var addSchedule = newSchedule.ToSchedule();
                            addSchedule.TourPackage = package;

                            await _scheduleReposity.AddScheduleAsync(addSchedule);
                        }
                    }
                }

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
                            _voucherRepository.UpdateVoucher(existingVoucher, voucherDTO);
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

                            await _voucherRepository.AddVoucherAsync(addVoucher);
                        }
                    }
                }

                return await _context.SaveChangesAsync() > 0 ? "Package updated successfully" : "Failed to update package";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }
}
