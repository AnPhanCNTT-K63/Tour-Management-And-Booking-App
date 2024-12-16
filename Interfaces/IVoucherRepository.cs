using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces
{
    public interface IVoucherRepository
    {
        Task AddVoucherAsync(Voucher voucher);
        Task AddRangeVouchersAsync(IEnumerable<Voucher> vouchers, TourPackage package);
        void UpdateVoucher(Voucher existingVoucher, UpdateVoucherDTO voucherDTO);
        void RemoveVouchers(IEnumerable<Voucher> vouchers);
    }
}
