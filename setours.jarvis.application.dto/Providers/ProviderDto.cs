using Newtonsoft.Json;

namespace setours.jarvis.application.dto.Providers
{
    public class ProviderDto :IDataTransferObject
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "pr_chain_id")]
        public int? ProviderChainId { get; set; }

        [JsonProperty(PropertyName = "pr_status_id")]
        public int ProviderStatusId { get; set; }

        [JsonProperty(PropertyName = "ge_document_id")]
        public int DocumentId { get; set; }

        [JsonProperty(PropertyName = "ge_country_id")]
        public int CountryId { get; set; }

        [JsonProperty(PropertyName = "ge_city_id")]
        public int CityId { get; set; }

        [JsonProperty(PropertyName = "trading_name")]
        public string TradingName { get; set; }

        [JsonProperty(PropertyName = "legal_name")]
        public string LegalName { get; set; }

        [JsonProperty(PropertyName = "registration_number")]
        public string RegistrationNumber { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "zipcode")]
        public string ZipCode { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "website")]
        public string Website { get; set; }


        [JsonProperty(PropertyName = "pr_chain")]
        public ProviderChainDto ProviderChain { get; set; }
    }
}
