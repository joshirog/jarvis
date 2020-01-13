using System.Text.Json.Serialization;

namespace setours.jarvis.application.dto.Providers
{
    public class ProviderStatusDto : IDataTransferObject
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("created_by")]
        public string CreatedBy { get; set; }

        [JsonPropertyName("updated_by")]
        public string UpdatedBy { get; set; }
    }
}
