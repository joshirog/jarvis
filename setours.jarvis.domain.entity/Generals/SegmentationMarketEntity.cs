using setours.jarvis.domain.entity.Contacts;
using System;
using System.Collections.Generic;

namespace setours.jarvis.domain.entity.Generals
{
    public class SegmentationMarketEntity : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public List<ContactDetailEntity> ContactDetail { get; set; }
    }
}
