using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using travelApp1.Models;

namespace travelApp1.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public ApiService()
        {
            _httpClient = new HttpClient();

            _baseUrl = Properties.Settings.Default.ApiUrl;

        }

        private void SetAuthorizationHeader()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Properties.Settings.Default.AccessToken);
            }
        }

        public async Task<HttpResponseMessage> GetAsync(string endpoint)
        {
            try
            {
                SetAuthorizationHeader();
                var response = await _httpClient.GetAsync($"{_baseUrl}/{endpoint}");
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while making GET request: {ex.Message}", ex);
            }
        }

        public async Task<HttpResponseMessage> PostAsync(string endpoint, object data)
        {
            try
            {
                SetAuthorizationHeader();

                var jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync($"{_baseUrl}/{endpoint}", content);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while making POST request: {ex.Message}", ex);
            }
        }

        public async Task<HttpResponseMessage> PutAsync(string endpoint, object data)
        {
            try
            {
                SetAuthorizationHeader();
                var jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync($"{_baseUrl}/{endpoint}", content);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while making PUT request: {ex.Message}", ex);
            }
        }

        public async Task<HttpResponseMessage> PatchAsync(string endpoint, object data)
        {
            try
            {
                SetAuthorizationHeader();
                var jsonData = JsonConvert.SerializeObject(data);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage(new HttpMethod("PATCH"), $"{_baseUrl}/{endpoint}")
                {
                    Content = content
                };
                var response = await _httpClient.SendAsync(request);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while making PATCH request: {ex.Message}", ex);
            }
        }

        public async Task<HttpResponseMessage> DeleteAsync(string endpoint)
        {
            try
            {
                SetAuthorizationHeader();
                var response = await _httpClient.DeleteAsync($"{_baseUrl}/{endpoint}");
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while making DELETE request: {ex.Message}", ex);
            }
        }
    }
}
