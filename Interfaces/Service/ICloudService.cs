namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface ICloudService
    {
        Task<string> UploadFile(IFormFile file);
        Task<string> UploadFileAsync(string filePath, string keyName);
        Task<string> UploadFileStreamAsync(Stream fileStream, string keyName);
    }
}
