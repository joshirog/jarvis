using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.entity.Providers;
using System;
using System.Collections.Generic;

namespace setours.jarvis.domain.entity.Services
{
    public class ServiceEntity : IEntity
    {
        public int Id { get; set; }

        public int? ProviderId { get; set; }

        public int ServiceTypeId { get; set; }

        public int ServiceStatusId { get; set; }

        public int CountryId { get; set; }

        public int CityId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }

        public bool IsOnlineRate { get; set; }

        public bool IsPreferred { get; set; }

        public string CodeSetra { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }



        public ProviderEntity Provider { get; set; }

        public ServiceTypeEntity ServiceType { get; set; }

        public ServiceStatusEntity ServiceStatus { get; set; }

        public LocationEntity Country { get; set; }

        public LocationEntity City { get; set; }

        public List<ServiceDetailEntity> ServiceDetails { get; set; }
    }
}
