using Newtonsoft.Json;

namespace SVN.Highcharts.Structures
{
    public class Title
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string text { get; set; }
    }
}