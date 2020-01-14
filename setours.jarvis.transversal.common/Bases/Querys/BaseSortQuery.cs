using Newtonsoft.Json;

namespace setours.jarvis.transversal.common.Bases.Querys
{
    public class BaseSortQuery
    {
        [JsonProperty(PropertyName = "field")]
        public string Field { get; set; }

        [JsonProperty(PropertyName = "ascending")]
        public bool Ascending { get; set; }
    }
}
