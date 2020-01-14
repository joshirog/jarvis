﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using setours.jarvis.domain.entity.Generals;
using System;

namespace setours.jarvis.infrastructure.persistence.Generals
{
    public class OccupationConfiguration : IEntityTypeConfiguration<OccupationEntity>
    {
        public void Configure(EntityTypeBuilder<OccupationEntity> builder)
        {
            builder.ToTable("ge_occupation");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasAnnotation("Npgsql:ValueGenerationStrategy",
                    Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.SerialColumn)
                .ValueGeneratedOnAdd()
                .HasComment("Llave primaria de la tabla");

            builder.Property(x => x.Abbreviation)
                .HasColumnName("abbreviation")
                .IsRequired()
                .HasMaxLength(8)
                .HasComment("Abreviatura de la ocupacion");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(150)
                .HasComment("Nombre de la ocupacion");

            builder.Property(x => x.Description)
                .HasColumnName("description")
                .IsRequired()
                .HasMaxLength(150)
                .HasComment("Descripcion de la ocupacion del servicio o tarifa");

            builder.Property(x => x.Status)
                .HasColumnName("status")
                .IsRequired()
                .HasMaxLength(1)
                .IsFixedLength()
                .HasDefaultValue("A")
                .HasComment("Estado A: Activo, I: Inactivo, X: Eliminado");

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
        }
    }
}
