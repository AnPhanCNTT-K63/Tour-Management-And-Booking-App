using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Mappers;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class TravelerRepository : ITravelerRepository
    {
        private readonly ApplicationDbContext _context;
        public TravelerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddRangeAsync(IEnumerable<Traveler> travelers)
        {
            await _context.Travelers.AddRangeAsync(travelers);
        }
    }
}
