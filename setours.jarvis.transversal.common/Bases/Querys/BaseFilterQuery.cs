using Newtonsoft.Json;
using System.Collections.Generic;

namespace setours.jarvis.transversal.common.Bases.Querys
{
    public class BaseFilterQuery
    {
        [JsonProperty(PropertyName = "field")]
        public string Field { get; set; }

        [JsonProperty(PropertyName = "operator")]
        public string Operator { get; set; }

        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }

        [JsonProperty(PropertyName = "filters")]
        public IEnumerable<BaseFilterQuery> Filters { get; set; }
    }
}
