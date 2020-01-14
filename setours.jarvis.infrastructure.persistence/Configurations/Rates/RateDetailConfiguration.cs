﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Rates;
using System;
using System.Collections.Generic;
using System.Text;

namespace setours.jarvis.infrastructure.persistence.Rates
{
    public class RateDetailConfiguration : IEntityTypeConfiguration<RateDetailEntity>
    {
        public void Configure(EntityTypeBuilder<RateDetailEntity> builder)
        {
            builder.ToTable("ra_details");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.RateDateId)
                .HasColumnName("ra_date_id")
                .IsRequired()
                .HasComment("Llave foranea con ra_date_id");

            builder.Property(x => x.OccupationId)
                .HasColumnName("ge_occupancy_id")
                .IsRequired()
                .HasComment("Llave foranea con ge_occupancy");

            builder.Property(x => x.CurrencyId)
                .HasColumnName("ge_currency_id")
                .IsRequired()
                .HasComment("Llave foranea con ge_currency");

            builder.Property(x => x.Status)
                .HasColumnName("status")
                .IsRequired()
                .HasMaxLength(1)
                .IsFixedLength()
                .HasDefaultValue("A")
                .HasComment("Estado A: Activo, I: Inactivo, X: Eliminado");

            builder.Property(x => x.Cost)
                .HasColumnName("cost")
                .IsRequired()
                .HasComment("Costo");

            builder.Property(x => x.SalePrice)
                .HasColumnName("sale_price")
                .IsRequired()
                .HasComment("Precio de venta");

            builder.Property(x => x.IsEditable)
                .HasColumnName("is_editable")
                .IsRequired()
                .HasComment("Flag para permitir editar los precios fuera de tarifa");

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
                .WithMany(x => x.RateDetails)
                .HasForeignKey(x => x.RateDateId);

            builder.HasOne(x => x.Occupation)
                .WithMany(x => x.RateDetails)
                .HasForeignKey(x => x.OccupationId);

            builder.HasOne(x => x.Currency)
                .WithMany(x => x.RateDetails)
                .HasForeignKey(x => x.CurrencyId);
        }
    }
}
