using setours.jarvis.domain.entity.Providers;
using System;
using System.Collections.Generic;

namespace setours.jarvis.domain.entity.Contacts
{
    public class ContactEntity : IEntity
    {
        public int Id { get; set; }

        public int ContactTypeId { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public bool IsNotifiable { get; set; }

        public string CodeSetra { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public ContactTypeEntity ContactType { get; set; }

        public List<ContactDataEntity> ContactDatas { get; set; }

        public List<ProviderContactEntity> ProviderContacts { get; set; }
    }
}
