using TravelWebBackEndCore.Interfaces;
using TravelWebBackEndCore.Services;

namespace TravelWebBackEndCore.Repositories
{
    public class CloudRepository : ICloudRepository
    {
        private readonly ICloundService _cloudService;
        public CloudRepository(ICloundService cloudService)
        {
            _cloudService = cloudService;
        }
        public async Task<string> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return "File is missing or empty.";
            }

            try
            {
                string keyName = Path.GetFileName(file.FileName);

                using (var fileStream = file.OpenReadStream())
                {
                    var fileUrl = await _cloudService.UploadFileStreamAsync(fileStream, keyName);
                    return "File uploaded successfully.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
