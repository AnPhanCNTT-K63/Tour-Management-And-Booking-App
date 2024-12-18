using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class VoucherRepository : IVoucherRepository
    {
        private readonly ApplicationDbContext _context;
        public VoucherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddRangeAsync(IEnumerable<Voucher> vouchers)
        {
            await _context.Vouchers.AddRangeAsync(vouchers);
        }

        public async Task AddVoucherAsync(Voucher voucher)
        {
            await _context.Vouchers.AddAsync(voucher);
        }

        public void RemoveVouchers(IEnumerable<Voucher> vouchers)
        {
            _context.Vouchers.RemoveRange(vouchers);
        }

    }
}
