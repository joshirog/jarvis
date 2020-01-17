using setours.jarvis.domain.entity.Contacts;
using System;

namespace setours.jarvis.domain.entity.Providers
{
    public class ProviderContactEntity : IEntity
    {
        public int Id { get; set; }

        public int ProviderId { get; set; }

        public int ContactId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public ProviderEntity Provider { get; set; }

        public ContactEntity Contanct { get; set; }
    }
}
