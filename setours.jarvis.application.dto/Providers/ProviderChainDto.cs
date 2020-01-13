namespace setours.jarvis.application.dto.Providers
{
    public class ProviderChainDto : IDataTransferObject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }
    }
}
