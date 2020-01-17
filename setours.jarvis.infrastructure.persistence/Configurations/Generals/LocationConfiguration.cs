using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Generals;

namespace setours.jarvis.infrastructure.persistence.Configurations.Generals
{
    public class LocationConfiguration : IEntityTypeConfiguration<LocationEntity>
    {
        public void Configure(EntityTypeBuilder<LocationEntity> builder)
        {
            builder.ToTable("ge_locations");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.ReferenceId)
                .IsRequired(false)
                .HasColumnName("ge_location_id")
                .HasComment("Llave foranea con ge_locations, recursividad - opcional");

            builder.Property(x => x.Code)
                .HasColumnName("code")
                .IsRequired()
                .HasMaxLength(5)
                .HasComment("Codigo de la ubicacion");

            builder.Property(x => x.Type)
                .HasColumnName("type")
                .IsRequired()
                .HasMaxLength(1)
                .IsFixedLength()
                .HasComment("Tipo de ubigeo P: Pais, C: Ciudad");

            builder.Property(x => x.Status)
                .HasColumnName("status")
                .IsRequired()
                .HasMaxLength(1)
                .IsFixedLength()
                .HasDefaultValue("A")
                .HasComment("Estado A: Activo, I: Inactivo, X: Eliminado");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(150)
                .HasComment("Nombre de la ubicacion");

            builder.Property(x => x.IsDestination)
                .HasColumnName("is_destination")
                .IsRequired()
                .HasDefaultValue(false)
                .HasComment("Indicador para verificar si es un destino de servicio");

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


            builder.HasOne(x => x.Location)
                .WithMany(x => x.Locations)
                .HasForeignKey(x => x.ReferenceId);
        }
    }
}
