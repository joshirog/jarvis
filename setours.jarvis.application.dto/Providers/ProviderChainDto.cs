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

        [JsonProperty(PropertyName = "created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty(PropertyName = "updated_by")]
        public string UpdatedBy { get; set; }
    }
}
