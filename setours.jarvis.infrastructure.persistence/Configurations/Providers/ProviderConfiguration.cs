using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Providers;

namespace setours.jarvis.infrastructure.persistence.Configurations.Providers
{
    public class ProviderConfiguration : IEntityTypeConfiguration<ProviderEntity>
    {
        public void Configure(EntityTypeBuilder<ProviderEntity> builder)
        {
            builder.ToTable("pr_providers");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");


            builder.Property(x => x.ProviderChainId)
                .HasColumnName("pr_chain_id")
                .IsRequired(false)
                .HasComment("Llave foranea con pr_chains opcional");

            builder.Property(x => x.ProviderStatusId)
                .HasColumnName("pr_status_id")
                .IsRequired()
                .HasComment("Llave foranea con pr_status");

            builder.Property(x => x.DocumentId)
                .HasColumnName("ge_document_id")
                .IsRequired()
                .HasComment("Llave foranea con ge_general");

            builder.Property(x => x.CountryId)
                .HasColumnName("ge_country_id")
                .HasComment("Llave foranea con ge_locations");

            builder.Property(x => x.CityId)
                .HasColumnName("ge_city_id")
                .HasComment("Llave foranea con ge_locations");

            builder.Property(x => x.LeganName)
                .HasColumnName("legal_name")
                .IsRequired()
                .HasMaxLength(120)
                .HasComment("Razon social del proveedor");

            builder.Property(x => x.TradingName)
                .HasColumnName("trading_name")
                .IsRequired()
                .HasMaxLength(120)
                .HasComment("Razon comercial del proveedor");

            builder.Property(x => x.RegistrationNumber)
                .IsRequired()
                .HasColumnName("registration_number")
                .HasMaxLength(30)
                .HasComment("Documento fiscal del proveedor");

            builder.Property(x => x.Address)
                .HasColumnName("address")
                .HasComment("Direccion fiscal del proveedor");

            builder.Property(x => x.ZipCode)
                .HasColumnName("zio_code")
                .IsRequired(false)
                .HasMaxLength(30)
                .HasComment("Direccion fiscal del proveedor");

            builder.Property(x => x.Phone)
                .HasColumnName("phone")
                .IsRequired(false)
                .HasMaxLength(25)
                .HasComment("Numero de telefono fiscal del proveedor");

            builder.Property(x => x.Website)
                .HasColumnName("website")
                .IsRequired(false)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasComment("Sitio web oficial del proveedor");

            builder.Property(x => x.CodeSetra)
                .HasColumnName("code_setra")
                .IsRequired(false)
                .HasMaxLength(20)
                .HasComment("Llave primaria del sistema version 1");

            builder.Property(x => x.CreatedBy)
                .HasColumnName("created_by")
                .IsRequired()
                .HasMaxLength(50)
                .HasComment("Usuario que genero el registro");

            builder.Property(x => x.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired()
                .HasDefaultValue(DateTime.Now)
                .HasComment("Fecha de generacion el registro");

            builder.Property(x => x.UpdatedBy)
                .HasColumnName("updated_by")
                .IsRequired(false)
                .HasMaxLength(50)
                .HasComment("Ultimo usuario que actualizo el registro");

            builder.Property(x => x.UpdatedAt)
                .HasColumnName("updated_at")
                .IsRequired(false)
                .HasComment("ultima fecha de actualizacion el registro");


            builder.HasOne(x => x.ProviderChain)
                .WithMany(x => x.Providers)
                .HasForeignKey(x => x.ProviderChainId);

            builder.HasOne(x => x.Status)
                .WithMany(x => x.Providers)
                .HasForeignKey(x => x.ProviderStatusId);

            builder.HasOne(x => x.Country)
                .WithMany(x => x.CountryProviders)
                .HasForeignKey(x => x.CountryId);

            builder.HasOne(x => x.City)
                .WithMany(x => x.CityProviders)
                .HasForeignKey(x => x.CityId);

            builder.HasOne(x => x.Document)
                .WithMany(x => x.Providers)
                .HasForeignKey(x => x.DocumentId);

            builder.HasIndex(x => x.RegistrationNumber)
                .IsUnique();
        }
    }
}
