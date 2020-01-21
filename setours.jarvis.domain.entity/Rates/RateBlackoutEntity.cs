using System;

namespace setours.jarvis.domain.entity.Rates
{
    public class RateBlackoutEntity : IEntity
    {
        public int Id { get; set; }

        public int RateId { get; set; }

        public DateTime DateIn { get; set; }

        public DateTime DateOut { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }



        public RateEntity Rate { get; set; }
    }
}
