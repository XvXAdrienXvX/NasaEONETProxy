using Newtonsoft.Json;
using System.Collections.Generic;

namespace NASAGatewayTest.Models
{
    public class EONETEventResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("events")]
        public List<EventsResponse> Events { get; set; }
    }
}
