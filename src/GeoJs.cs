using System.Net.Http;
using System.Net.Http.Headers;

namespace GeoJsApi
{
    public class GeoJs
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://get.geojs.io/v1";
        public GeoJs()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
               "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetCurrentIp()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/ip.json");
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> GetCurrentGeo()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/geo.json");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCurrentPtr()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/dns/ptr.json");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCurrentCountry()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/ip/country.json");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCountryByIp(string ipAddress)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/ip/country/{ipAddress}.json");
            return await response.Content.ReadAsStringAsync();
        }
        
        public async Task<string> GetGeoByIp(string ipAddress)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/ip/geo/{ipAddress}.json");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
