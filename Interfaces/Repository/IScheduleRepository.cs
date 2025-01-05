using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces.Repository
{
    public interface IScheduleRepository
    {
        Task AddScheduleAsync(Schedule schedule);
        Task AddRangeAsync(IEnumerable<Schedule> schedules);
        void RemoveSchedules(IEnumerable<Schedule> schedules);

    }
}
