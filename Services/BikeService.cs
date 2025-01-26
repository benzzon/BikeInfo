using System.Net.Http.Json;
using BikeInfo.Models;
using Microsoft.Extensions.Logging;

namespace BikeApp.Services
{
    public class BikeService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://www.benzzon.se/api/v1/bzbikes/";
        private readonly ILogger _logger;

        public BikeService(HttpClient httpClient, ILoggerFactory loggerFactory)
        {
            _httpClient = httpClient;
            _logger = loggerFactory.CreateLogger<BikeService>();
        }

        public async Task<List<Bike>> GetBikesAsync(string manufacturer)
        {
            try
            {
                _logger.LogInformation("Fetching motorcycles for manufacturer: {Manufacturer}", manufacturer);
                var data = await _httpClient.GetFromJsonAsync<List<Bike>>($"{BaseUrl}{manufacturer}") ?? new List<Bike>();

                return data;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching motorcycles from API");
                throw;
            }
        }
    }
}
