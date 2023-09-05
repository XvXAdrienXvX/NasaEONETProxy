using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASAGatewayTest.Models
{
    public class EventsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("categories")]
        public List<CategoryResponse> Categories { get; set; }
        [JsonProperty("sources")]
        public List<SourceResponse> Sources { get; set; }
        [JsonProperty("geometries")]
        public List<GeometryResponse> Geometries { get; set; }
    }
}
