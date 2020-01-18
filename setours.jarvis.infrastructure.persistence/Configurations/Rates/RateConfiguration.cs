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

            builder.Property(x => x.RestrictionTypeId)
                .HasColumnName("ge_market_type_id")
                .IsRequired()
                .HasComment("Llave foranea con la tabla ge_market_types");

            builder.Property(x => x.RateStatusId)
                .HasColumnName("ra_status_id")
                .IsRequired()
                .HasComment("Llave foranea con ra_status");

            builder.Property(x => x.CurrencyId)
                .HasColumnName("ge_currency_id")
                .IsRequired()
                .HasComment("Llave foranea con ge_currency");

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

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnName("description")
                .HasMaxLength(30)
                .HasComment("Descripcion detallada del servicio");

            builder.Property(x => x.Estimated)
                .HasColumnName("estimated")
                .IsRequired()
                .HasComment("Margen de estimacion o preyeccion");

            builder.Property(x => x.Link)
                .IsRequired(false)
                .HasColumnName("link")
                .HasComment("Link de enlace al documento de tarifa del proveedor");

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

            builder.HasOne(x => x.RateStatus)
               .WithMany(x => x.Rates)
               .HasForeignKey(x => x.RateStatusId);

            builder.HasOne(x => x.Currency)
               .WithMany(x => x.Rates)
               .HasForeignKey(x => x.CurrencyId);

            builder.HasOne(x => x.RestrictionType)
              .WithMany(x => x.Rates)
              .HasForeignKey(x => x.RestrictionTypeId);
        }
    }
}
