using Newtonsoft.Json;

namespace SVN.Highcharts.Structures
{
    public class Labels
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string format { get; set; }
    }
}