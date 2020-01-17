using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Services;
using System;

namespace setours.jarvis.infrastructure.persistence.Services
{
    public class ServiceDetailConfiguration : IEntityTypeConfiguration<ServiceDetailEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceDetailEntity> builder)
        {
            builder.ToTable("se_details");

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
                .IsRequired(true)
                .HasComment("Llave foranea con se_service_id");

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

            builder.Property(x => x.CapacityMax)
                .HasColumnName("capacity_max")
                .HasComment("Capacidad maxima de personas en el servicio");

            builder.Property(x => x.CapacityMaxAdult)
                .HasColumnName("capacity_max_adult")
                .HasComment("Capacidad maxima de adultos en el servicio");

            builder.Property(x => x.CapacityMaxChild)
                .HasColumnName("capacity_max_child")
                .HasComment("Capacidad maxima de niños en el servicio");

            builder.Property(x => x.AgeMaxChild)
                .HasColumnName("age_max_child")
                .HasComment("Edad maxima para el niño");

            builder.Property(x => x.IsExtraCostChild)
                .HasColumnName("is_extra_cost_child")
                .HasDefaultValue(false)
                .HasComment("Flag para agregar el costo extra para el niño");

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


            builder.HasOne(x => x.Service)
                .WithMany(x => x.ServiceDetails)
                .HasForeignKey(x => x.ServiceId);
        }
    }
}
