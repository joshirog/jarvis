namespace setours.jarvis.application.dto.Generals
{
    public class DocumentDto : IDataTransferObject
    {
        public int Id { get; set; }

        public string Abbreviation { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }
    }
}
