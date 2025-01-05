namespace TravelWebBackEndCore.DTOs.Booking
{
    public class MyBooking
    {
        public int Id { get; set; }
        public int TourPackageId { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public string Status { get; set; }
        public int NumOfPeople { get; set; }
        public DateTime? DateOfTravel { get; set; }
    }
}
