using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SVN.Highcharts.Enums;
using System.Collections.Generic;

namespace SVN.Highcharts.Structures
{
    public class Series
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string color { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Plot> data { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SeriesType type { get; set; }
    }
}