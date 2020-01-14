using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Rates;
using System;

namespace setours.jarvis.infrastructure.persistence.Rates
{
    public class RateConfiguration : IEntityTypeConfiguration<RateEntity>
    {
        public void Configure(EntityTypeBuilder<RateEntity> builder)
        {
            builder.ToTable("ra_rates");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.ServiceDetailId)
                .HasColumnName("se_detail_id")
                .IsRequired()
                .HasComment("Llave foranea con se_details");

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

            builder.Property(x => x.Status)
                .HasColumnName("status")
                .IsRequired()
                .HasMaxLength(1)
                .IsFixedLength()
                .HasDefaultValue("A")
                .HasComment("Estado A: Activo, I: Inactivo, X: Eliminado");

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnName("description")
                .HasMaxLength(30)
                .HasComment("Descripcion detallada del servicio");

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


            builder.HasOne(x => x.ServiceDetail)
                .WithMany(x => x.Rates)
                .HasForeignKey(x => x.ServiceDetailId);
        }
    }
}
