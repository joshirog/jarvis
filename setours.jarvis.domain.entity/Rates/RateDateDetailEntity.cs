using setours.jarvis.domain.entity.Generals;
using System;
using System.Collections.Generic;

namespace setours.jarvis.domain.entity.Rates
{
    public class RateDateDetailEntity : IEntity
    {
        public int Id { get; set; }

        public int RateDateId { get; set; }

        public int AccommodationId { get; set; }

        public int CurrencyId { get; set; }

        public string Status { get; set; }

        public decimal Cost { get; set; }

        public decimal SalePrice { get; set; }

        public decimal Margin { get; set; }

        public decimal Estimated { get; set; }
        
        public bool IsEditable { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public RateDateEntity RateDate { get; set; }

        public AccommodationEntity Accommodation { get; set; }
    }
}
