using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface IVoucherService
    {
        Task AddVoucherAsync(Voucher voucher);
        Task AddRangeVouchersAsync(IEnumerable<Voucher> vouchers, TourPackage package);
        void UpdateVoucher(Voucher existingVoucher, UpdateVoucherDTO voucherDTO);
        void RemoveVouchers(IEnumerable<Voucher> vouchers);
    }
}
