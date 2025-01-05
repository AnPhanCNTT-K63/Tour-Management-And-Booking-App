namespace TravelWebBackEndCore.DTOs.Voucher
{
    public class UpdateVoucherDTO
    {
        public int Id { get; set; }
        public Decimal Discount { get; set; }
        public string? Title { get; set; }
        public string? Code { get; set; }
    }
}
