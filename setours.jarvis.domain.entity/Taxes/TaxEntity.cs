using System;
using System.Collections.Generic;
using setours.jarvis.domain.entity.Rates;

namespace setours.jarvis.domain.entity.Taxes
{
    public class TaxEntity : IEntity
    {
        public int Id { get; set; }

        public string Abbreviation { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public List<TaxDetailEntity> TaxDetails { get; set; }

        public List<RateTaxEntity> RateTaxes { get; set; }
    }
}
