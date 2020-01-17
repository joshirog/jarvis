using Microsoft.EntityFrameworkCore;
using setours.jarvis.domain.entity.Clients;
using setours.jarvis.domain.entity.Contacts;
using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.entity.Providers;
using setours.jarvis.domain.entity.Rates;
using setours.jarvis.domain.entity.Services;
using setours.jarvis.domain.entity.Taxes;
using setours.jarvis.infrastructure.persistence.Configurations.Clients;
using setours.jarvis.infrastructure.persistence.Configurations.Contacts;
using setours.jarvis.infrastructure.persistence.Configurations.Generals;
using setours.jarvis.infrastructure.persistence.Configurations.Providers;
using setours.jarvis.infrastructure.persistence.Configurations.Rates;
using setours.jarvis.infrastructure.persistence.Configurations.Services;
using setours.jarvis.infrastructure.persistence.Configurations.Taxes;
using setours.jarvis.infrastructure.persistence.Generals;
using setours.jarvis.infrastructure.persistence.Rates;
using setours.jarvis.infrastructure.persistence.Services;

namespace setours.jarvis.infrastructure.persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {
        
        }

        public DbSet<SegmentationEntity> Segmentations { get; set; }
        public DbSet<DocumentEntity> Documents { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<AccommodationEntity> Occupations { get; set; }
        public DbSet<CurrencyEntity> Currency { get; set; }
        public DbSet<AdditionalEntity> Additionals { get; set; }
        public DbSet<InclusionEntity> Inclustions { get; set; }
        public DbSet<MarketEntity> Markets { get; set; }

        public DbSet<TaxEntity> Taxes { get; set; }
        public DbSet<TaxDetailEntity> TaxDetails { get; set; }

        public DbSet<ProviderStatusEntity> ProviderStatus { get; set; }
        public DbSet<ProviderEntity> Providers { get; set; }
        public DbSet<ProviderChainEntity> ProviderChains { get; set; }
        public DbSet<ProviderContactEntity> ProviderContacts { get; set; }

        public DbSet<ClientTypeEntity> ClientTypes { get; set; }

        public DbSet<ContactTypeEntity> ContactTypes { get; set; }
        public DbSet<ContactMediaEntity> ContactMedias { get; set; }
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<ContactDetailEntity> ContactDetails { get; set; }
        public DbSet<ContactDataEntity> ContactData { get; set; }

        public DbSet<ServiceStatusEntity> ServiceStatus { get; set; }
        public DbSet<ServiceTypeEntity> ServiceTypes { get; set; }
        public DbSet<ServiceDetailEntity> ServiceDetails { get; set; }
        public DbSet<ServiceDetailAdditionalEntity> ServiceDetailAdditionals { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }

        public DbSet<RateStatusEntity> RateStatus { get; set; }
        public DbSet<RateDateEntity> RateDates { get; set; }
        public DbSet<RateDateDetailEntity> RateDateDetails { get; set; }
        public DbSet<RateDateDayEntity> RateDateDays { get; set; }
        public DbSet<RateDateBlackoutEntity> RateDateBlackouts { get; set; }
        public DbSet<RateEntity> Rates { get; set; }
        public DbSet<RateInclusionEntity> RateInclusions { get; set; }
        public DbSet<RateTaxEntity> RateTaxes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new SegmentationConfiguration());
            builder.ApplyConfiguration(new CurrencyConfiguration());
            builder.ApplyConfiguration(new DocumentContiguration());
            builder.ApplyConfiguration(new AccommodationConfiguration());
            builder.ApplyConfiguration(new LocationConfiguration());
            builder.ApplyConfiguration(new AdditionalConfiguration());
            builder.ApplyConfiguration(new InclusionConfiguration());
            builder.ApplyConfiguration(new MarketConfiguration());

            builder.ApplyConfiguration(new TaxConfiguration());
            builder.ApplyConfiguration(new TaxDetailConfiguration());

            builder.ApplyConfiguration(new ProviderConfiguration());
            builder.ApplyConfiguration(new ProviderChainConfiguration());
            builder.ApplyConfiguration(new ProviderStatusConfiguration());
            builder.ApplyConfiguration(new ProviderContactConfiguration());

            builder.ApplyConfiguration(new ClientTypeConfiguration());

            builder.ApplyConfiguration(new ContactTypeConfiguration());
            builder.ApplyConfiguration(new ContactMediaConfiguration());
            builder.ApplyConfiguration(new ContactConfiguration());
            builder.ApplyConfiguration(new ContactDetailConfiguration());
            builder.ApplyConfiguration(new ContactDataConfiguration());

            builder.ApplyConfiguration(new ServiceStatusConfiguration());
            builder.ApplyConfiguration(new ServiceTypeConfiguration());
            builder.ApplyConfiguration(new ServiceDetailConfiguration());
            builder.ApplyConfiguration(new ServiceConfiguration());
            builder.ApplyConfiguration(new ServiceDetailAdditionalConfiguration());

            builder.ApplyConfiguration(new RateStatusConfiguration());
            builder.ApplyConfiguration(new RateDateDetailConfiguration());
            builder.ApplyConfiguration(new RateDateConfiguration());
            builder.ApplyConfiguration(new RateConfiguration());
            builder.ApplyConfiguration(new RateDateDayConfiguration());
            builder.ApplyConfiguration(new RateDateBlackoutConfiguration());
            builder.ApplyConfiguration(new RateInclusionConfiguration());
            builder.ApplyConfiguration(new RateTaxConfiguration());
        }
    }
}