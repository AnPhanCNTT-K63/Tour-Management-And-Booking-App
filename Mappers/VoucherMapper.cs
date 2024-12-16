using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class VoucherMapper
    {
        public static Voucher ToVoucher(this CreateVoucherDTO voucherDto)
        {
            return new Voucher
            {
                Discount = voucherDto.Discount,
                Title = voucherDto.Title,
                Code = voucherDto.Code
            };
        }
    }
}
