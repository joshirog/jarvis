namespace setours.jarvis.application.dto.Generals
{
    public class LocationDto : IDataTransferObject
    {
        public int Id { get; set; }

        public int? ReferenceId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }
    }
}
