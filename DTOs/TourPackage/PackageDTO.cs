namespace TravelWebBackEndCore.DTOs.TourPackage
{
    public class PackageDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = new string("No name");
        public string Description { get; set; } = new string("No description");
        public string Image { get; set; } = new string("No image");
        public decimal Price { get; set; }
        public string Activities { get; set; } = new string("No activities");
        public bool IsChangeSchedule { get; set; }
        public bool IsRefund { get; set; }
        public string CheckIn { get; set; } = new string("No check in method");
        public decimal VAT { get; set; }
        public int Quantity { get; set; }
        public int TourId { get; set; }

    }
}
