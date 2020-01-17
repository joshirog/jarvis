using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Taxes;
using System;

namespace setours.jarvis.infrastructure.persistence.Configurations.Taxes
{
    public class TaxDetailConfiguration : IEntityTypeConfiguration<TaxDetailEntity>
    {
        public void Configure(EntityTypeBuilder<TaxDetailEntity> builder)
        {
            builder.ToTable("ta_tax_details");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.TaxId)
                .HasColumnName("ta_tax_id")
                .IsRequired()
                .HasComment("Llave foranea con la tabla ta_taxes");

            builder.Property(x => x.CountryId)
                .HasColumnName("ge_country_id")
                .IsRequired()
                .HasComment("Llave foranea con la tabla ge_locations");

            builder.Property(x => x.Value)
                .HasColumnName("value")
                .IsRequired()
                .HasComment("Valor del impuesto");

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


            builder.HasOne(x => x.Tax)
                .WithMany(x => x.TaxDetails)
                .HasForeignKey(x => x.TaxId);

            builder.HasOne(x => x.Country)
                .WithMany(x => x.CountryTaxes)
                .HasForeignKey(x => x.CountryId);
        }
    }
}
