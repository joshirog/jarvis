using System;
using setours.jarvis.domain.entity.Generals;

namespace setours.jarvis.domain.entity.Contacts
{
    public class ContactDetailEntity
    {
        public int Id { get; set; }

        public int ContactId { get; set; }

        public int SegmentationMarketId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public ContactEntity Contact { get; set; }

        public SegmentationMarketEntity SegmentationMarket { get; set; }
    }
}
