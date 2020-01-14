using setours.jarvis.domain.entity.Rates;
using System;
using System.Collections.Generic;

namespace setours.jarvis.domain.entity.Services
{
    public class ServiceDetailEntity : IEntity
    {
        public int Id { get; set; }

        public int ServiceId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }

        public int CapacityMax { get; set; }

        public int CapacityMaxAdult { get; set; }

        public int CapacityMaxChild { get; set; }

        public string CodeSetra { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public ServiceEntity Service { get; set; }

        public List<RateEntity> Rates { get; set; }
    }
}
