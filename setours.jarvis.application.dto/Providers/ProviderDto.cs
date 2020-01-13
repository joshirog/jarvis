namespace setours.jarvis.application.dto.Providers
{
    public class ProviderDto :IDataTransferObject
    {
        public int Id { get; set; }

        public int? ProviderChainId { get; set; }

        public int ProviderStatusId { get; set; }

        public int DocumentId { get; set; }

        public int CountryId { get; set; }

        public int CityId { get; set; }

        public string TradingName { get; set; }

        public string LeganName { get; set; }

        public string RegistrationNumber { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }
    }
}
