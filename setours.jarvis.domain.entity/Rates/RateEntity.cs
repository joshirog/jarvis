using setours.jarvis.domain.entity.Services;
using System;
using System.Collections.Generic;

namespace setours.jarvis.domain.entity.Rates
{
    public class RateEntity : IEntity
    {
        public int Id { get; set; }

        public int ServiceDetailId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }

        public string CodeSetra { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public ServiceDetailEntity ServiceDetail { get; set; }

        public List<RateDateEntity> RateDates { get; set; }
    }
}
