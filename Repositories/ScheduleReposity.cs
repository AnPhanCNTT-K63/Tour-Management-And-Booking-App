using TravelWebBackEndCore.Data;
using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.Interfaces;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Repositories
{
    public class ScheduleReposity : IScheduleReposity
    {
        private readonly ApplicationDbContext _context;
        public ScheduleReposity(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddScheduleAsync(Schedule schedule)
        {
            await _context.Schedules.AddAsync(schedule);
        }

        public void UpdateSchedule(Schedule existingSchedule, UpdateScheduleDTO scheduleDTO)
        {
            existingSchedule.TravelDay = scheduleDTO.TravelDay;
        }

        public void RemoveSchedules(IEnumerable<Schedule> schedules)
        {
            _context.Schedules.RemoveRange(schedules);
        }

        public async Task AddRangeSchedulesAsync(IEnumerable<Schedule> schedules, TourPackage package)
        {
            if (package.Schedules == null)
            {
                package.Schedules = new List<Schedule>();
            }

            foreach (var schedule in schedules)
            {
                schedule.TourPackage = package;
            }
            await _context.Schedules.AddRangeAsync(package.Schedules);
        }
    }
}
