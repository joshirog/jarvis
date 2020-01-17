using System;
using System.Collections.Generic;
using setours.jarvis.domain.entity.Services;

namespace setours.jarvis.domain.entity.Generals
{
    public class ServiceTypeEntity : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsInternal { get; set; }

        public string CodeSetra { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public List<ServiceEntity> Services { get; set; }
    }
}
