using System;
using System.Collections.Generic;

namespace setours.jarvis.domain.entity.Rates
{
    public class RateStatusEntity : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public List<RateEntity> Rates { get; set; }
    }
}
