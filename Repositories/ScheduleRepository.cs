using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.Interfaces.Repository;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ApplicationDbContext _context;
        public ScheduleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddScheduleAsync(Schedule schedule)
        {
            await _context.Schedules.AddAsync(schedule);
        }

        public void RemoveSchedules(IEnumerable<Schedule> schedules)
        {
            _context.Schedules.RemoveRange(schedules);
        }

        public async Task AddRangeAsync(IEnumerable<Schedule> schedules)
        {
            await _context.Schedules.AddRangeAsync(schedules);
        }

    }
}
