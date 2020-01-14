using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Rates;
using System;

namespace setours.jarvis.infrastructure.persistence.Rates
{
    public class RateDateConfiguration : IEntityTypeConfiguration<RateDateEntity>
    {
        public void Configure(EntityTypeBuilder<RateDateEntity> builder)
        {
            builder.ToTable("ra_dates");

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
                .HasComment("Llave foranea con se_details");

            builder.Property(x => x.TravelDateStart)
                .HasColumnName("travel_date_start")
                .IsRequired()
                .HasComment("Fecha de inicio de la vigencia");

            builder.Property(x => x.TravelDateEnd)
                .HasColumnName("travel_date_end")
                .IsRequired()
                .HasComment("Fecha final de la vigencia");

            builder.Property(x => x.BookingDateStart)
                .HasColumnName("booking_date_start")
                .IsRequired()
                .HasComment("Fecha de inicio para la compra");

            builder.Property(x => x.BookingDateStart)
                .HasColumnName("booking_date_end")
                .IsRequired()
                .HasComment("Fecha final para la compra");

            builder.Property(x => x.Status)
                .HasColumnName("status")
                .IsRequired()
                .HasMaxLength(1)
                .IsFixedLength()
                .HasDefaultValue("A")
                .HasComment("Estado A: Activo, I: Inactivo, X: Eliminado");

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
                .WithMany(x => x.RateDates)
                .HasForeignKey(x => x.RateId);
        }
    }
}
