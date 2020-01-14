using Newtonsoft.Json;
using System.Collections.Generic;

namespace setours.jarvis.transversal.common.Bases.Querys
{
    public class BaseSearchQuery
    {
        [JsonProperty(PropertyName = "includes")]
        public List<BaseIncludeQuery> Includes { get; set; }

        [JsonProperty(PropertyName = "filters")]
        public List<BaseFilterQuery> Filters { get; set; }

        [JsonProperty(PropertyName = "sort")]
        public List<BaseSortQuery> Sort { get; set; }

        [JsonProperty(PropertyName = "page")]
        public int Page { get; set; }

        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }
    }
}
