using setours.jarvis.domain.entity.Providers;
using System;
using System.Collections.Generic;

namespace setours.jarvis.domain.entity.Generals
{
    public class LocationEntity : IEntity
    {
        public int Id { get; set; }

        public int? ReferenceId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public string CodeSetra { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public LocationEntity Location { get; set; }

        public List<LocationEntity> Locations { get; set; }

        public List<ProviderEntity> CountryProviders { get; set; }

        public List<ProviderEntity> CityProviders { get; set; }
    }
}
