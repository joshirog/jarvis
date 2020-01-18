using setours.jarvis.domain.entity.Generals;
using System;

namespace setours.jarvis.domain.entity.Services
{
    public class ServiceDescriptionEntity : IEntity
    {
        public int Id { get; set; }

        public int ServiceId { get; set; }

        public int LanguageId { get; set; }

        public string Value { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public ServiceEntity Service { get; set; }

        public LanguageEntity Language { get; set; }
    }
}
