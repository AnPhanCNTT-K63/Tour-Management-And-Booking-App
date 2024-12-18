using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Interfaces.Service;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Services
{
    public class VoucherService : IVoucherService
    {
        private readonly ApplicationDbContext _context;
        public VoucherService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddRangeVouchersAsync(IEnumerable<Voucher> vouchers, TourPackage package)
        {
            if (package.Vouchers == null)
            {
                package.Vouchers = new List<Voucher>();
            }

            foreach (var voucher in vouchers)
            {
                voucher.TourPackage = package;
            }
            await _context.Vouchers.AddRangeAsync(package.Vouchers);
        }

        public async Task AddVoucherAsync(Voucher voucher)
        {
            await _context.Vouchers.AddAsync(voucher);
        }

        public void RemoveVouchers(IEnumerable<Voucher> vouchers)
        {
            _context.Vouchers.RemoveRange(vouchers);
        }

        public void UpdateVoucher(Voucher existingVoucher, UpdateVoucherDTO voucherDTO)
        {
            existingVoucher.Discount = voucherDTO.Discount;
            existingVoucher.Title = voucherDTO.Title;
            existingVoucher.Code = voucherDTO.Code;
        }
    }
}
