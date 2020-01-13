namespace setours.jarvis.application.dto.Providers
{
    public class ProviderStatusDto : IDataTransferObject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
