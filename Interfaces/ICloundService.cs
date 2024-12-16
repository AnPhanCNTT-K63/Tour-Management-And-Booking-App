namespace TravelWebBackEndCore.Interfaces
{
    public interface ICloundService
    {
        Task<string> UploadFileAsync(string filePath, string keyName);
        Task<string> UploadFileStreamAsync(Stream fileStream, string keyName);
    }
}
