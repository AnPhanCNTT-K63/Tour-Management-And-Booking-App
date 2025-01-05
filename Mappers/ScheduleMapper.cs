using TravelWebBackEndCore.DTOs.Schedule;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class ScheduleMapper
    {
        public static ScheduleDTO ToScheduleDto(this Schedule scheduleModel)
        {
            return new ScheduleDTO
            {
                Id = scheduleModel.Id,
                TravelDay = scheduleModel.TravelDay,
            };
        }
        public static Schedule ToSchedule(this CreateScheduleDTO scheduleDto)
        {
            return new Schedule
            {
                TravelDay = scheduleDto.TravelDay,

            };
        }
    }
}
