using Newtonsoft.Json;

namespace NASAGatewayTest.Models
{
    public class SourceResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
