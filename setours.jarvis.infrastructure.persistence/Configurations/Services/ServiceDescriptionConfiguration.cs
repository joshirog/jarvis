using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Services;
using System;

namespace setours.jarvis.infrastructure.persistence.Configurations.Services
{
    public class ServiceDescriptionConfiguration : IEntityTypeConfiguration<ServiceDescriptionEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceDescriptionEntity> builder)
        {
            builder.ToTable("se_service_descriptions");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.ServiceId)
                .HasColumnName("se_service_id")
                .IsRequired()
                .HasComment("Llave foranea con la tabla se_services");

            builder.Property(x => x.LanguageId)
                .HasColumnName("ge_language_id")
                .IsRequired()
                .HasComment("Llave foranea con la tabla ge_languages");

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
                .HasComment("Ultima fecha de actualizacion el registro");
        }
    }
}
