using Newtonsoft.Json;

namespace setours.jarvis.application.dto.Providers
{
    public class ProviderChainDto : IDataTransferObject
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
