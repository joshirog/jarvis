﻿using setours.jarvis.domain.entity.Rates;
using System;
using System.Collections.Generic;

namespace setours.jarvis.domain.entity.Generals
{
    public class CurrencyEntity : IEntity
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Abbreviation { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string CodeSetra { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public List<RateDetailEntity> RateDetails { get; set; }

        public List<RateEntity> Rates { get; set; }
    }
}
