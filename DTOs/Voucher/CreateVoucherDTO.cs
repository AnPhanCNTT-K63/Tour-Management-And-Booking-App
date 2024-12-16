namespace TravelWebBackEndCore.DTOs.Voucher
{
    public class CreateVoucherDTO
    {
        public Decimal Discount { get; set; }
        public string? Title { get; set; }
        public string? Code { get; set; }

    }
}
