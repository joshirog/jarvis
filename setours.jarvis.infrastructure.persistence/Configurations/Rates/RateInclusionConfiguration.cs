using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Rates;
using System;

namespace setours.jarvis.infrastructure.persistence.Configurations.Rates
{
    public class RateInclusionConfiguration : IEntityTypeConfiguration<RateInclusionEntity>
    {
        public void Configure(EntityTypeBuilder<RateInclusionEntity> builder)
        {
            builder.ToTable("ra_rate_inclusions");

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
                .HasComment("Llave foranea con ra_rates");

            builder.Property(x => x.InclusionId)
                .HasColumnName("ge_inclusion_id")
                .IsRequired()
                .HasComment("Llave foranea con ge_inclusions");

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


            builder.HasOne(x => x.Rate)
                .WithMany(x => x.RateInclusions)
                .HasForeignKey(x => x.RateId);

            builder.HasOne(x => x.Inclusion)
                .WithMany(x => x.RateInclusions)
                .HasForeignKey(x => x.InclusionId);
        }
    }
}
