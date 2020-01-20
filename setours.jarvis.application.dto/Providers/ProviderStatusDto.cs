using Newtonsoft.Json;

namespace setours.jarvis.application.dto.Providers
{
    public class ProviderStatusDto : IDataTransferObject
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
