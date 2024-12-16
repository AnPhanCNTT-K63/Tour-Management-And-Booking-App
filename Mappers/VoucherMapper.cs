using TravelWebBackEndCore.DTOs.Voucher;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class VoucherMapper
    {
        public static VoucherDTO toVoucherDTO(this Voucher voucherModel)
        {
            return new VoucherDTO
            {
                Id = voucherModel.Id,
                Discount = voucherModel.Discount,
                Title = voucherModel.Title,
                Code = voucherModel.Code
            };
        }
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
