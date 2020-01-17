using System;

namespace setours.jarvis.domain.entity.Contacts
{
    public class ContactDataEntity : IEntity
    {
        public int Id { get; set; }

        public int ContactId { get; set; }

        public int ContactMediaId { get; set; }

        public string Value { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public ContactEntity Contact { get; set; }

        public ContactMediaEntity ContactMedia { get; set; }
    }
}
