using Newtonsoft.Json;

namespace NASAGateway.Models
{
    public class SourceResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
