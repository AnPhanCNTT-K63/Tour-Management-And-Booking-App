namespace TravelWebBackEndCore.Helpers
{
    public class QueryTour
    {
        public string? region { get; set; }
        public string? searchBy { get; set; }
        public string? searchQuery { get; set; }
        public string? sortBy { get; set; }
        public int[]? priceRange { get; set; }
    }
}
