using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NASAGateway.Models
{
    public class GeometryResponse
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("coordinates")]
        public List<double> Coordinates { get; set; }
    }
}
