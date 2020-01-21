using setours.jarvis.domain.entity.Generals;
using System;

namespace setours.jarvis.domain.entity.Rates
{
    public class RateRestrictionEntity : IEntity
    {
        public int Id { get; set; }

        public int RateId { get; set; }

        public int RestrictionId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public RateEntity Rate { get; set; }

        public RestrictionTypeEntity RestrictionType { get; set; }
    }
}
