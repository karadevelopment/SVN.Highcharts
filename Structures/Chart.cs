using Newtonsoft.Json;
using System.Collections.Generic;

namespace SVN.Highcharts.Structures
{
    public class Chart
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Legend legend { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string renderTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Series> series { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Title subtitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Title title { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public XAxis xAxis { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public YAxis yAxis { get; set; }
    }
}