using Newtonsoft.Json;

namespace SVN.Highcharts.Structures
{
    public class Plot
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double x { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double y { get; set; }
    }
}