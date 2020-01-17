using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Rates;
using System;

namespace setours.jarvis.infrastructure.persistence.Configurations.Rates
{
    public class RateTaxConfiguration : IEntityTypeConfiguration<RateTaxEntity>
    {
        public void Configure(EntityTypeBuilder<RateTaxEntity> builder)
        {
            builder.ToTable("ra_rate_taxes");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.RateId)
                .HasColumnName("ra_rate_id")
                .IsRequired()
                .HasComment("Llave foranea con la tabla ra_rates");

            builder.Property(x => x.TaxId)
                .HasColumnName("ta_tax_id")
                .IsRequired()
                .HasComment("Llave foranea con la tabla ta_taxes");

            builder.Property(x => x.Value)
                .HasColumnName("value")
                .IsRequired()
                .HasComment("Valor del impuesto");

            builder.Property(x => x.Is_Included)
                .HasColumnName("is_included")
                .IsRequired()
                .HasComment("Indicador para verificar si el impuesto esta incluido");

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
