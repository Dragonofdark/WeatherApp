using Newtonsoft.Json;
using System.Diagnostics;

namespace WeatherApp
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<Clima> GetWeatherData(string query) {
            Clima climaData = null;

            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode) { 
                    var content = await response.Content.ReadAsStringAsync();
                    climaData = JsonConvert.DeserializeObject<Clima>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return climaData;
        }
    }
}
