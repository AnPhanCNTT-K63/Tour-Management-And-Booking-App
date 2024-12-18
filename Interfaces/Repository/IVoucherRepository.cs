using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Repository
{
    public interface IVoucherRepository
    {
        Task AddVoucherAsync(Voucher voucher);
        Task AddRangeAsync(IEnumerable<Voucher> vouchers);
        void RemoveVouchers(IEnumerable<Voucher> vouchers);
    }
}
