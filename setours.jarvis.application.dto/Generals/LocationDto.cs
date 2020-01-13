using System.Text.Json.Serialization;

namespace setours.jarvis.application.dto.Generals
{
    public class LocationDto : IDataTransferObject
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("reference_id")]
        public int? ReferenceId { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("created_by")]
        public string CreatedBy { get; set; }

        [JsonPropertyName("updated_by")]
        public string UpdatedBy { get; set; }
    }
}
