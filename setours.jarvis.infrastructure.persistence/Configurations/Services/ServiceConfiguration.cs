using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Services;
using System;

namespace setours.jarvis.infrastructure.persistence.Services
{
    public class ServiceConfiguration : IEntityTypeConfiguration<ServiceEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceEntity> builder)
        {
            builder.ToTable("se_services");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.ProviderId)
                .HasColumnName("pr_provider_id")
                .IsRequired(false)
                .HasComment("Llave foranea con pr_providers opcional");

            builder.Property(x => x.ServiceTypeId)
                .HasColumnName("se_type_id")
                .IsRequired()
                .HasComment("Llave foranea con se_types");

            builder.Property(x => x.ServiceStatusId)
                .HasColumnName("se_status_id")
                .IsRequired()
                .HasComment("Llave foranea con se_status");

            builder.Property(x => x.CountryId)
                .HasColumnName("ge_country_id")
                .HasComment("Llave foranea con ge_locations");

            builder.Property(x => x.CityId)
                .HasColumnName("ge_city_id")
                .HasComment("Llave foranea con ge_locations");

            builder.Property(x => x.Code)
                .HasColumnName("code")
                .IsRequired()
                .HasMaxLength(120)
                .HasComment("Codigo auto generado por el sistema");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(120)
                .HasComment("Nombre del servicio");

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnName("description")
                .HasMaxLength(30)
                .HasComment("Descripcion detallada del servicio");

            builder.Property(x => x.Note)
                .IsRequired()
                .HasColumnName("note")
                .HasComment("Notas adicionales del servicio");

            builder.Property(x => x.Address)
                .HasColumnName("address")
                .HasComment("Dirección fiscal del proveedor");

            builder.Property(x => x.ZipCode)
                .HasColumnName("zip_code")
                .IsRequired(false)
                .HasMaxLength(30)
                .HasComment("Código postal del proveedor");

            builder.Property(x => x.Phone)
                .HasColumnName("phone")
                .IsRequired(false)
                .HasMaxLength(25)
                .HasComment("Número de telefono fiscal del proveedor");

            builder.Property(x => x.Website)
                .HasColumnName("website")
                .IsRequired(false)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasComment("Sitio web oficial del proveedor");

            builder.Property(x => x.IsOnlineRate)
                .HasColumnName("is_online_rate")
                .HasDefaultValue(false)
                .HasComment("Flag para mostrar el servicios a clientes externos");

            builder.Property(x => x.IsPreferred)
                .HasColumnName("is_preferred")
                .HasDefaultValue(false)
                .HasComment("Flag para mostrar el servicios a clientes externos");

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


            builder.HasOne(x => x.Provider)
                .WithMany(x => x.Services)
                .HasForeignKey(x => x.ProviderId);

            builder.HasOne(x => x.ServiceType)
                .WithMany(x => x.Services)
                .HasForeignKey(x => x.ServiceTypeId);

            builder.HasOne(x => x.ServiceStatus)
                .WithMany(x => x.Services)
                .HasForeignKey(x => x.ServiceStatusId);

            builder.HasOne(x => x.Country)
                .WithMany(x => x.CountryServices)
                .HasForeignKey(x => x.CountryId);

            builder.HasOne(x => x.City)
                .WithMany(x => x.CityServices)
                .HasForeignKey(x => x.CityId);
        }
    }
}
