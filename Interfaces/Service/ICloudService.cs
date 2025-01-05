using Microsoft.AspNetCore.Mvc;

namespace TravelWebBackEndCore.Interfaces.Service
{
    public interface ICloudService
    {
        Task<IActionResult> UploadFile(IFormFile file, string folderName);
        Task<string> UploadFileAsync(string filePath, string keyName);
        Task<string> UploadFileStreamAsync(Stream fileStream, string keyName);
    }
}
