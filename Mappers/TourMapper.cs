using TravelWebBackEndCore.DTOs.Tour;
using TravelWebBackEndCore.DTOs.TourPackage;
using TravelWebBackEndCore.Models;

namespace TravelWebBackEndCore.Mappers
{
    public static class TourMapper
    {
        public static TourDTO ToTourDto(this Tour tourModel)
        {
            return new TourDTO
            {
                Id = tourModel.Id,
                Name = tourModel.Name,
                Region = tourModel.Region,
                Country = tourModel.Country,
                City = tourModel.City,
                Image = tourModel.Image,
                Description = tourModel.Description,
                Price = tourModel.TourPackages != null && tourModel.TourPackages.Count != 0
                ? tourModel.TourPackages.Min(x => x.Price)
                : 0,
                Opening = tourModel.Opening,
                IsDeleted = tourModel.IsDeleted,
                Ending = tourModel.Ending,
                CreatedAt = tourModel.CreatedAt,
                UpdatedAt = tourModel.UpdatedAt,
                DeletedAt = tourModel.DeletedAt,
            };
        }

        public static TourDTO ToTourDetailDto(this Tour tourModel)
        {
            return new TourDTO
            {
                Id = tourModel.Id,
                Name = tourModel.Name,
                Region = tourModel.Region,
                Country = tourModel.Country,
                City = tourModel.City,
                Image = tourModel.Image,
                Description = tourModel.Description,
                Price = tourModel.TourPackages != null && tourModel.TourPackages.Count != 0
                ? tourModel.TourPackages.Min(x => x.Price)
                : 0,
                TourPackages = tourModel.TourPackages != null
                ? tourModel.TourPackages.Select(x => x.ToPackageDto()).ToList()
                : new List<PackageDTO>(),
                UserId = tourModel.User.Id,
                IsDeleted = tourModel.IsDeleted,
                Opening = tourModel.Opening,
                Ending = tourModel.Ending,
            };
        }

        public static Tour ToTour(this CreateTourDTO createTourDto)
        {
            return new Tour
            {
                Name = createTourDto.Name,
                Region = createTourDto.Region,
                Country = createTourDto.Country,
                City = createTourDto.City,
                Image = createTourDto.Image,
                Description = createTourDto.Description,
                Opening = createTourDto.Opening,
                CreatedAt = DateTime.Now,
                Ending = createTourDto.Ending
            };
        }
    }
}
