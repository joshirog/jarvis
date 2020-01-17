using setours.jarvis.domain.entity.Generals;
using System;

namespace setours.jarvis.domain.entity.Services
{
    public class ServiceDetailAdditionalEntity : IEntity
    {
        public int Id { get; set; }

        public int ServiceDetailId { get; set; }

        public int AdditionalId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public ServiceDetailEntity ServiceDetail { get; set; }

        public AdditionalEntity Additional { get; set; }
    }
}
