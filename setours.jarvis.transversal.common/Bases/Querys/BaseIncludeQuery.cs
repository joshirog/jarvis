using Newtonsoft.Json;

namespace setours.jarvis.transversal.common.Bases.Querys
{
    public class BaseIncludeQuery
    {
        [JsonProperty(PropertyName = "table")]
        public string Table { get; set; }
    }
}
