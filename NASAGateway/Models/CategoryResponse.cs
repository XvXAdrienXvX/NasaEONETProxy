using Newtonsoft.Json;

namespace NASAGateway.Models
{
    public class CategoryResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
