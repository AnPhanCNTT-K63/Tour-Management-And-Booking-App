using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Repository
{
    public interface ITravelerRepository
    {
        Task AddRangeAsync(IEnumerable<Traveler> travelers);
    }
}
