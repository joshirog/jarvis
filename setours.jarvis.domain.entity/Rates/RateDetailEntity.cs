using setours.jarvis.domain.entity.Generals;
using System;

namespace setours.jarvis.domain.entity.Rates
{
    public class RateDetailEntity : IEntity
    {
        public int Id { get; set; }

        public int RateDateId { get; set; }

        public int OccupationId { get; set; }

        public int CurrencyId { get; set; }

        public string Status { get; set; }

        public decimal Cost { get; set; }

        public decimal SalePrice { get; set; }

        public bool IsEditable { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public RateDateEntity RateDate { get; set; }

        public OccupationEntity Occupation { get; set; }

        public CurrencyEntity Currency { get; set; }
    }
}
