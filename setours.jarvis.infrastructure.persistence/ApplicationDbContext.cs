using Microsoft.EntityFrameworkCore;
using setours.jarvis.domain.entity.Generals;
using setours.jarvis.domain.entity.Providers;
using setours.jarvis.infrastructure.persistence.Configurations.Generals;
using setours.jarvis.infrastructure.persistence.Configurations.Providers;

namespace setours.jarvis.infrastructure.persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<DocumentEntity> Documents { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<ProviderStatusEntity> ProviderStatus { get; set; }
        public DbSet<ProviderEntity> Providers { get; set; }
        public DbSet<ProviderChainEntity> ProviderChains { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new DocumentContiguration());
            builder.ApplyConfiguration(new LocationConfiguration());
            builder.ApplyConfiguration(new ProviderConfiguration());
            builder.ApplyConfiguration(new ProviderChainConfiguration());
            builder.ApplyConfiguration(new ProviderStatusConfiguration());
        }
    }
}
