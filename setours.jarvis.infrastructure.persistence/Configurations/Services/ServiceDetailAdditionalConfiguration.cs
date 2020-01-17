using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Services;
using System;

namespace setours.jarvis.infrastructure.persistence.Configurations.Services
{
    public class ServiceDetailAdditionalConfiguration : IEntityTypeConfiguration<ServiceDetailAdditionalEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceDetailAdditionalEntity> builder)
        {
            builder.ToTable("se_detail_additionals");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.ServiceDetailId)
                .HasColumnName("se_detail_id")
                .IsRequired()
                .HasComment("Llave foranea con tabla se_details");

            builder.Property(x => x.AdditionalId)
                .HasColumnName("ge_additional_id")
                .IsRequired()
                .HasComment("Llave foranea con tabla ge_additionals");

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
                .WithMany(x => x.ServiceDetailAdditionals)
                .HasForeignKey(x => x.ServiceDetailId);

            builder.HasOne(x => x.Additional)
                .WithMany(x => x.ServiceDetailAdditionals)
                .HasForeignKey(x => x.AdditionalId);
        }
    }
}
