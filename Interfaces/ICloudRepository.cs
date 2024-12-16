namespace TravelWebBackEndCore.Interfaces
{
    public interface ICloudRepository
    {
        Task<string> UploadFile(IFormFile file);
    }
}
