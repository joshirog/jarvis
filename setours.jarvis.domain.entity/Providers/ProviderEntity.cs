using System;
using System.Collections.Generic;
using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.entity.Services;

namespace setours.jarvis.domain.entity.Providers
{
    public class ProviderEntity : IEntity
    {
        public int Id { get; set; }

        public int? ProviderChainId { get; set; }

        public int ProviderStatusId { get; set; }

        public int DocumentId { get; set; }

        public int CountryId { get; set; }

        public int CityId { get; set; }

        public string TradingName { get; set; }

        public string LegalName { get; set; }

        public string RegistrationNumber { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }

        public string CodeSetra { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }


        public ProviderChainEntity ProviderChain { get; set; }

        public ProviderStatusEntity Status { get; set; }

        public LocationEntity Country { get; set; }

        public LocationEntity City { get; set; }

        public DocumentTypeEntity DocumentType { get; set; }

        public List<ServiceEntity> Services { get; set; }

        public List<ProviderContactEntity> ProviderContacts { get; set; }
    }
}
