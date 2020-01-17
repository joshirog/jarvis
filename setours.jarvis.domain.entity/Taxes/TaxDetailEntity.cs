using setours.jarvis.domain.entity.Generals;
using System;

namespace setours.jarvis.domain.entity.Taxes
{
    public class TaxDetailEntity
    {
        public int Id { get; set; }

        public int TaxId { get; set; }

        public int CountryId { get; set; }

        public decimal Value { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public TaxEntity Tax { get; set; }

        public LocationEntity Country { get; set; }
    }
}
