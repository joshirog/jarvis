﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Rates;
using System;

namespace setours.jarvis.infrastructure.persistence.Configurations.Rates
{
    public class RateDateBlackoutConfiguration : IEntityTypeConfiguration<RateDateBlackoutEntity>
    {
        public void Configure(EntityTypeBuilder<RateDateBlackoutEntity> builder)
        {
            builder.ToTable("ra_rate_date_blackouts");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.RateDateId)
                .HasColumnName("ra_rate_date_id")
                .IsRequired()
                .HasComment("Llave foranea con se_details");

            builder.Property(x => x.DateIn)
               .HasColumnName("data_in")
               .IsRequired()
               .HasComment("Blackout fecha inicio");

            builder.Property(x => x.DateOut)
               .HasColumnName("data_out")
               .IsRequired()
               .HasComment("Blackout fecha final");

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


            builder.HasOne(x => x.RateDate)
                .WithMany(x => x.RateDateBlackouts)
                .HasForeignKey(x => x.RateDateId);
        }
    }
}
