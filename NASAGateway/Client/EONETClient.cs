using NASAGateway.Models;
using Newtonsoft.Json;

namespace NASAGateway.Client
{
    public class EONETClient : IEONETClient
    {
        private readonly HttpClient _httpClient;
        private readonly string APIKEY = Environment.GetEnvironmentVariable("EONET_APIKEY");
        public EONETClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<EONETEventResponse> GetEventsByStatus(string status)
        {
            try
            {
               var result = await _httpClient.GetFromJsonAsync<EONETEventResponse>($"?status={status}&?api_key={APIKEY}");
             
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private EONETEventResponse LoadJson()
        {
            EONETEventResponse items = new EONETEventResponse();
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            String Root = Directory.GetCurrentDirectory();
            string path = Path.Combine(Root, @"DB\data.json");
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<EONETEventResponse>(json);
            }

            return items;
        }
    }
}
