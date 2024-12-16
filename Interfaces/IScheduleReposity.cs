using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Interfaces
{
    public interface IScheduleReposity
    {
        Task AddScheduleAsync(Schedule schedule);
        Task AddRangeSchedulesAsync(IEnumerable<Schedule> schedules, TourPackage package);
        void UpdateSchedule(Schedule existingSchedule, UpdateScheduleDTO scheduleDTO);
        void RemoveSchedules(IEnumerable<Schedule> schedules);
    }
}
