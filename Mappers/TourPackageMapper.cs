using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class TourPackageMapper
    {
        public static PackageDTO ToPackageDto(this TourPackage packageModel)
        {
            return new PackageDTO
            {
                Id = packageModel.Id,
                Name = packageModel.Name,
                Description = packageModel.Description,
                Image = packageModel.Image,
                Price = packageModel.Price,
                Activities = packageModel.Activities,
                IsChangeSchedule = packageModel.IsChangeSchedule,
                IsRefund = packageModel.IsRefund,
                CheckIn = packageModel.CheckIn,
                VAT = packageModel.VAT,
                Quantity = packageModel.Quantity,
                TourId = packageModel.TourId,
            };
        }

        public static TourPackage ToPackage(this CreatePackageDTO packageDto)
        {
            return new TourPackage
            {
                Name = packageDto.Name,
                Description = packageDto.Description,
                Image = packageDto.Image,
                Price = packageDto.Price,
                Activities = packageDto.Activities,
                IsChangeSchedule = packageDto.IsChangeSchedule,
                IsRefund = packageDto.IsRefund,
                CheckIn = packageDto.CheckIn,
                VAT = packageDto.VAT,
                Quantity = packageDto.Quantity,
                Schedules = packageDto.Schedules?.Select(s => s.ToSchedule()).ToList(),
                Vouchers = packageDto.Vouchers?.Select(v => v.ToVoucher()).ToList(),
            };
        }
    }
}
