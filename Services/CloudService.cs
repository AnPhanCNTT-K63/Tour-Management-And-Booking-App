
using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using TravelWebBackEndCore.Interfaces.Service;


namespace TravelWebBackEndCore.Services
{
    public class CloudService : ICloudService
    {
        private readonly string _accessKey;
        private readonly string _secretKey;
        private readonly string _region;
        private readonly string _bucketName;
        private readonly IAmazonS3 _s3Client;

        public CloudService(IConfiguration configuration)
        {
            _accessKey = configuration["AWS:AccessKey"] ?? throw new ArgumentNullException(nameof(_accessKey));
            _secretKey = configuration["AWS:SecretKey"] ?? throw new ArgumentNullException(nameof(_secretKey));
            _region = configuration["AWS:Region"] ?? throw new ArgumentNullException(nameof(_region));
            _bucketName = configuration["AWS:BucketName"] ?? throw new ArgumentNullException(nameof(_bucketName));

            // Initialize the AmazonS3Client
            _s3Client = new AmazonS3Client(_accessKey, _secretKey, RegionEndpoint.GetBySystemName(_region));
        }

        /// <summary>
        /// Uploads a file to S3 bucket.
        /// </summary>
        /// <param name="filePath">The local file path of the picture to be uploaded.</param>
        /// <param name="keyName">The key name to save the file as in the S3 bucket.</param>
        /// <returns>The URL of the uploaded file.</returns>
        /// 
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
                    var fileUrl = await UploadFileStreamAsync(fileStream, keyName);
                    return "File uploaded successfully.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public async Task<string> UploadFileAsync(string filePath, string keyName)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                throw new ArgumentException("Invalid file path.");
            }

            try
            {
                var fileTransferUtility = new TransferUtility(_s3Client);

                // Upload the file
                await fileTransferUtility.UploadAsync(filePath, _bucketName, keyName);

                // Return the file URL
                return $"https://{_bucketName}.s3.{_region}.amazonaws.com/{keyName}";
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("An error occurred while uploading the file: " + ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Uploads a file stream to S3 bucket.
        /// </summary>
        /// <param name="fileStream">The file stream to upload.</param>
        /// <param name="keyName">The key name to save the file as in the S3 bucket.</param>
        /// <returns>The URL of the uploaded file.</returns>
        public async Task<string> UploadFileStreamAsync(Stream fileStream, string keyName)
        {
            if (fileStream == null || fileStream.Length == 0)
            {
                throw new ArgumentException("Invalid file stream.");
            }

            try
            {
                var fileTransferUtility = new TransferUtility(_s3Client);

                // Upload the file stream
                await fileTransferUtility.UploadAsync(fileStream, _bucketName, keyName);

                // Return the file URL
                return $"https://{_bucketName}.s3.{_region}.amazonaws.com/{keyName}";
            }
            catch (Exception ex)
            {
                // Handle the exception
                Console.WriteLine("An error occurred while uploading the file: " + ex.Message);
                throw;
            }
        }
    }

}
