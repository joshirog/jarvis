﻿using System;

namespace setours.jarvis.domain.entity.Rates
{
    public class RateDayEntity : IEntity
    {
        public int Id { get; set; }

        public int RateId { get; set; }

        public int NumDay { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public RateEntity Rate { get; set; }
    }
}
