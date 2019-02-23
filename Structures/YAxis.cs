using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SVN.Highcharts.Enums;

namespace SVN.Highcharts.Structures
{
    public class YAxis
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Labels labels { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? max { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? min { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double minTickInterval { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long tickInterval { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Title title { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AxisType type { get; set; }
    }
}