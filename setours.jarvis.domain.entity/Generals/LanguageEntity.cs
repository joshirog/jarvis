using System;

namespace setours.jarvis.domain.entity.Generals
{
    public class LanguageEntity : IEntity
    {
        public int Id { get; set; }

        public string Abbreviature { get; set; }

        public string Name { get; set; }

        public string CodeSetra { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
