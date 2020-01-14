using Microsoft.EntityFrameworkCore;
using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.entity.Providers;
using setours.jarvis.domain.entity.Rates;
using setours.jarvis.domain.entity.Services;
using setours.jarvis.infrastructure.persistence.Configurations.Generals;
using setours.jarvis.infrastructure.persistence.Configurations.Providers;
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

        public DbSet<DocumentEntity> Documents { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<OccupationEntity> Occupations { get; set; }
        public DbSet<CurrencyEntity> Currency { get; set; }

        public DbSet<ProviderStatusEntity> ProviderStatus { get; set; }
        public DbSet<ProviderEntity> Providers { get; set; }
        public DbSet<ProviderChainEntity> ProviderChains { get; set; }

        public DbSet<ServiceStatusEntity> ServiceStatus { get; set; }
        public DbSet<ServiceTypeEntity> ServiceTypes { get; set; }
        public DbSet<ServiceDetailEntity> ServiceDetails { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }

        public DbSet<RateStatusEntity> RateStatus { get; set; }
        public DbSet<RateDetailEntity> RateDetails { get; set; }
        public DbSet<RateDateEntity> RateDates { get; set; }
        public DbSet<RateEntity> Rates { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CurrencyConfiguration());
            builder.ApplyConfiguration(new DocumentContiguration());
            builder.ApplyConfiguration(new OccupationConfiguration());
            builder.ApplyConfiguration(new LocationConfiguration());

            builder.ApplyConfiguration(new ProviderConfiguration());
            builder.ApplyConfiguration(new ProviderChainConfiguration());
            builder.ApplyConfiguration(new ProviderStatusConfiguration());

            builder.ApplyConfiguration(new ServiceStatusConfiguration());
            builder.ApplyConfiguration(new ServiceTypeConfiguration());
            builder.ApplyConfiguration(new ServiceDetailConfiguration());
            builder.ApplyConfiguration(new ServiceConfiguration());

            builder.ApplyConfiguration(new RateStatusConfiguration());
            builder.ApplyConfiguration(new RateDetailConfiguration());
            builder.ApplyConfiguration(new RateDateConfiguration());
            builder.ApplyConfiguration(new RateConfiguration());
        }
    }
}