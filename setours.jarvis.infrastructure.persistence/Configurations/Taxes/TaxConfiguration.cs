using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Taxes;
using System;

namespace setours.jarvis.infrastructure.persistence.Configurations.Taxes
{
    public class TaxConfiguration : IEntityTypeConfiguration<TaxEntity>
    {
        public void Configure(EntityTypeBuilder<TaxEntity> builder)
        {
            builder.ToTable("ta_taxes");

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
                .HasComment("Nombre del tipo de impuesto");

            builder.Property(x => x.Abbreviation)
                .HasColumnName("abbreviation")
                .IsRequired()
                .HasMaxLength(10)
                .HasComment("Abreviatura del tipo de impuesto");

            builder.Property(x => x.Description)
                .HasColumnName("description")
                .IsRequired(false)
                .HasComment("Description del tipo de impuesto");

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
        }
    }
}
