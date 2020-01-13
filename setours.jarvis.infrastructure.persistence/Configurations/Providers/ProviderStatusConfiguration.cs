using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Providers;

namespace setours.jarvis.infrastructure.persistence.Configurations.Providers
{
    public class ProviderStatusConfiguration : IEntityTypeConfiguration<ProviderStatusEntity>
    {
        public void Configure(EntityTypeBuilder<ProviderStatusEntity> builder)
        {
            builder.ToTable("pr_status");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(150)
                .HasComment("Nombre del estado del proveedor");

            builder.Property(x => x.Description)
                .HasColumnName("description")
                .IsRequired(false)
                .HasComment("Descripcion detallada del estado del proveedor");

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

            /*
            builder.HasData(
                new ProviderStatusEntity() { Id = 1, Name = "Active", Description = "Status active provider", CreatedBy = "System" },
                new ProviderStatusEntity() { Id = 2, Name = "Inactive", Description = "Status inactive provider", CreatedBy = "System" },
                new ProviderStatusEntity() { Id = 3, Name = "Remove", Description = "Status removed provider", CreatedBy = "System" }
            );
            */
        }
    }
}
