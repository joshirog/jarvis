using System;
using System.Collections.Generic;
using System.Text;

namespace setours.jarvis.domain.entity.Rates
{
    public class RateDateEntity : IEntity
    {
        public int Id { get; set; }

        public int RateId { get; set; }

        public string Status { get; set; }

        public DateTime TravelDateStart { get; set; }

        public DateTime TravelDateEnd { get; set; }

        public DateTime? BookingDateStart { get; set; }

        public DateTime? BookingDateEnd { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public RateEntity Rate { get; set; }

        public List<RateDetailEntity> RateDetails { get; set; }
    }
}
