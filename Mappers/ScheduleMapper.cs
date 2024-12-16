using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class ScheduleMapper
    {
        public static Schedule ToSchedule(this CreateScheduleDTO scheduleDto)
        {
            return new Schedule
            {
                TravelDay = scheduleDto.TravelDay,

            };
        }
    }
}
