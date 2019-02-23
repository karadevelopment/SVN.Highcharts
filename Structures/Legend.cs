using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SVN.Highcharts.Enums;

namespace SVN.Highcharts.Structures
{
    public class Legend
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AlignType align { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? enabled { get; set; }
    }
}