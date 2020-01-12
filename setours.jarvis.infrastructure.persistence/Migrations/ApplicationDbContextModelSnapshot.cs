﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using setours.jarvis.infrastructure.persistence;

namespace setours.jarvis.infrastructure.persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("setours.jarvis.domain.entity.Generals.DocumentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasComment("Llave primaria de la tabla")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnName("abbreviation")
                        .HasColumnType("character varying(8)")
                        .HasComment("Abreviatura del tipo de documento")
                        .HasMaxLength(8);

                    b.Property<string>("CodeSetra")
                        .HasColumnName("code_setra")
                        .HasColumnType("character varying(20)")
                        .HasComment("Llave primaria del sistema version 1")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone")
                        .HasComment("Fecha de generacion el registro")
                        .HasDefaultValue(new DateTime(2020, 1, 12, 4, 54, 42, 967, DateTimeKind.Local).AddTicks(7300));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnName("created_by")
                        .HasColumnType("character varying(50)")
                        .HasComment("Usuario que genero el registro")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(150)")
                        .HasComment("Nombre del tipo de documento")
                        .HasMaxLength(150);

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("status")
                        .HasColumnType("character(1)")
                        .IsFixedLength(true)
                        .HasComment("Estado A: Activo, I: Inactivo, X: Eliminado")
                        .HasMaxLength(1)
                        .HasDefaultValue("A");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone")
                        .HasComment("ultima fecha de actualizacion el registro");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("updated_by")
                        .HasColumnType("character varying(50)")
                        .HasComment("Ultimo usuario que actualizo el registro")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ge_documents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abbreviation = "RUC",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "System",
                            Name = "Unique Registry of Taxpayers"
                        },
                        new
                        {
                            Id = 2,
                            Abbreviation = "DNI",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "System",
                            Name = "National identity document"
                        });
                });

            modelBuilder.Entity("setours.jarvis.domain.entity.Generals.LocationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasComment("Llave primaria de la tabla")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnName("code")
                        .HasColumnType("character varying(5)")
                        .HasComment("Codigo de la ubicacion")
                        .HasMaxLength(5);

                    b.Property<string>("CodeSetra")
                        .HasColumnName("code_setra")
                        .HasColumnType("character varying(20)")
                        .HasComment("Llave primaria del sistema version 1")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone")
                        .HasComment("Fecha de generacion el registro")
                        .HasDefaultValue(new DateTime(2020, 1, 12, 4, 54, 42, 987, DateTimeKind.Local).AddTicks(6660));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnName("created_by")
                        .HasColumnType("character varying(50)")
                        .HasComment("Usuario que genero el registro")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(150)")
                        .HasComment("Nombre de la ubicacion")
                        .HasMaxLength(150);

                    b.Property<int?>("ReferenceId")
                        .HasColumnName("ge_location_id")
                        .HasColumnType("integer")
                        .HasComment("Llave foranea con ge_locations, recursividad - opcional");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("status")
                        .HasColumnType("character(1)")
                        .IsFixedLength(true)
                        .HasComment("Estado A: Activo, I: Inactivo, X: Eliminado")
                        .HasMaxLength(1)
                        .HasDefaultValue("A");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone")
                        .HasComment("ultima fecha de actualizacion el registro");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("updated_by")
                        .HasColumnType("character varying(50)")
                        .HasComment("Ultimo usuario que actualizo el registro")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ReferenceId");

                    b.ToTable("ge_locations");
                });

            modelBuilder.Entity("setours.jarvis.domain.entity.Providers.ProviderChainEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasComment("Llave primaria de la tabla")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("CodeSetra")
                        .HasColumnName("code_setra")
                        .HasColumnType("character varying(20)")
                        .HasComment("Llave primaria del sistema version 1")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone")
                        .HasComment("Fecha de generacion el registro")
                        .HasDefaultValue(new DateTime(2020, 1, 12, 4, 54, 43, 10, DateTimeKind.Local).AddTicks(7980));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnName("created_by")
                        .HasColumnType("character varying(50)")
                        .HasComment("Usuario que genero el registro")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(150)")
                        .HasComment("Nombre de la candena del proveedor")
                        .HasMaxLength(150);

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("status")
                        .HasColumnType("character(1)")
                        .IsFixedLength(true)
                        .HasComment("Estado del proveedor A: Activo, I: Inactivo, X: Eliminado")
                        .HasMaxLength(1)
                        .HasDefaultValue("A");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone")
                        .HasComment("ultima fecha de actualizacion el registro");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("updated_by")
                        .HasColumnType("character varying(50)")
                        .HasComment("Ultimo usuario que actualizo el registro")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("pr_chains");
                });

            modelBuilder.Entity("setours.jarvis.domain.entity.Providers.ProviderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasComment("Llave primaria de la tabla")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("Address")
                        .HasColumnName("address")
                        .HasColumnType("text")
                        .HasComment("Direccion fiscal del proveedor");

                    b.Property<int>("CityId")
                        .HasColumnName("ge_city_id")
                        .HasColumnType("integer")
                        .HasComment("Llave foranea con ge_locations");

                    b.Property<string>("CodeSetra")
                        .HasColumnName("code_setra")
                        .HasColumnType("character varying(20)")
                        .HasComment("Llave primaria del sistema version 1")
                        .HasMaxLength(20);

                    b.Property<int>("CountryId")
                        .HasColumnName("ge_country_id")
                        .HasColumnType("integer")
                        .HasComment("Llave foranea con ge_locations");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone")
                        .HasComment("Fecha de generacion el registro")
                        .HasDefaultValue(new DateTime(2020, 1, 12, 4, 54, 42, 999, DateTimeKind.Local).AddTicks(3970));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnName("created_by")
                        .HasColumnType("character varying(50)")
                        .HasComment("Usuario que genero el registro")
                        .HasMaxLength(50);

                    b.Property<int>("DocumentId")
                        .HasColumnName("ge_document_id")
                        .HasColumnType("integer")
                        .HasComment("Llave foranea con ge_general");

                    b.Property<string>("LeganName")
                        .IsRequired()
                        .HasColumnName("legal_name")
                        .HasColumnType("character varying(120)")
                        .HasComment("Razon social del proveedor")
                        .HasMaxLength(120);

                    b.Property<string>("Phone")
                        .HasColumnName("phone")
                        .HasColumnType("character varying(25)")
                        .HasComment("Numero de telefono fiscal del proveedor")
                        .HasMaxLength(25);

                    b.Property<int?>("ProviderChainId")
                        .HasColumnName("pr_chain_id")
                        .HasColumnType("integer")
                        .HasComment("Llave foranea con pr_chains opcional");

                    b.Property<int>("ProviderStatusId")
                        .HasColumnName("pr_status_id")
                        .HasColumnType("integer")
                        .HasComment("Llave foranea con pr_status");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnName("registration_number")
                        .HasColumnType("character varying(30)")
                        .HasComment("Documento fiscal del proveedor")
                        .HasMaxLength(30);

                    b.Property<string>("TradingName")
                        .IsRequired()
                        .HasColumnName("trading_name")
                        .HasColumnType("character varying(120)")
                        .HasComment("Razon comercial del proveedor")
                        .HasMaxLength(120);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone")
                        .HasComment("ultima fecha de actualizacion el registro");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("updated_by")
                        .HasColumnType("character varying(50)")
                        .HasComment("Ultimo usuario que actualizo el registro")
                        .HasMaxLength(50);

                    b.Property<string>("Website")
                        .HasColumnName("website")
                        .HasColumnType("character(100)")
                        .IsFixedLength(true)
                        .HasComment("Sitio web oficial del proveedor")
                        .HasMaxLength(100);

                    b.Property<string>("ZipCode")
                        .HasColumnName("zio_code")
                        .HasColumnType("character varying(30)")
                        .HasComment("Direccion fiscal del proveedor")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DocumentId");

                    b.HasIndex("ProviderChainId");

                    b.HasIndex("ProviderStatusId");

                    b.HasIndex("RegistrationNumber")
                        .IsUnique();

                    b.ToTable("pr_providers");
                });

            modelBuilder.Entity("setours.jarvis.domain.entity.Providers.ProviderStatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasComment("Llave primaria de la tabla")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone")
                        .HasComment("Fecha de generacion el registro")
                        .HasDefaultValue(new DateTime(2020, 1, 12, 4, 54, 43, 13, DateTimeKind.Local).AddTicks(7360));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnName("created_by")
                        .HasColumnType("character varying(50)")
                        .HasComment("Usuario que genero el registro")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text")
                        .HasComment("Descripcion detallada del estado del proveedor");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(150)")
                        .HasComment("Nombre del estado del proveedor")
                        .HasMaxLength(150);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone")
                        .HasComment("Ultima fecha de actualizacion el registro");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("updated_by")
                        .HasColumnType("character varying(50)")
                        .HasComment("Ultimo usuario que actualizo el registro")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("pr_status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "System",
                            Description = "Status active provider",
                            Name = "Active"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "System",
                            Description = "Status inactive provider",
                            Name = "Inactive"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "System",
                            Description = "Status removed provider",
                            Name = "Remove"
                        });
                });

            modelBuilder.Entity("setours.jarvis.domain.entity.Generals.LocationEntity", b =>
                {
                    b.HasOne("setours.jarvis.domain.entity.Generals.LocationEntity", "Location")
                        .WithMany("Locations")
                        .HasForeignKey("ReferenceId");
                });

            modelBuilder.Entity("setours.jarvis.domain.entity.Providers.ProviderEntity", b =>
                {
                    b.HasOne("setours.jarvis.domain.entity.Generals.LocationEntity", "City")
                        .WithMany("CityProviders")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("setours.jarvis.domain.entity.Generals.LocationEntity", "Country")
                        .WithMany("CountryProviders")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("setours.jarvis.domain.entity.Generals.DocumentEntity", "Document")
                        .WithMany("Providers")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("setours.jarvis.domain.entity.Providers.ProviderChainEntity", "ProviderChain")
                        .WithMany("Providers")
                        .HasForeignKey("ProviderChainId");

                    b.HasOne("setours.jarvis.domain.entity.Providers.ProviderStatusEntity", "Status")
                        .WithMany("Providers")
                        .HasForeignKey("ProviderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}