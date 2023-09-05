using Newtonsoft.Json;

namespace NASAGatewayTest.Models
{
    public class CategoryResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
