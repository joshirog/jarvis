using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace setours.jarvis.infrastructure.persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ge_currency",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<string>(maxLength: 8, nullable: false, comment: "Codigo del la moneda"),
                    abbreviation = table.Column<string>(maxLength: 8, nullable: false, comment: "Nombre corto de la moneda"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la moneda"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 215, DateTimeKind.Local).AddTicks(3397), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_currency", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_documents",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    abbreviation = table.Column<string>(maxLength: 8, nullable: false, comment: "Abreviatura del tipo de documento"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del tipo de documento"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 220, DateTimeKind.Local).AddTicks(1812), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_documents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_locations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ge_location_id = table.Column<int>(nullable: true, comment: "Llave foranea con ge_locations, recursividad - opcional"),
                    Type = table.Column<string>(nullable: true),
                    code = table.Column<string>(maxLength: 5, nullable: false, comment: "Codigo de la ubicacion"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la ubicacion"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 227, DateTimeKind.Local).AddTicks(2987), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_locations", x => x.id);
                    table.ForeignKey(
                        name: "FK_ge_locations_ge_locations_ge_location_id",
                        column: x => x.ge_location_id,
                        principalTable: "ge_locations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ge_occupation",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    abbreviation = table.Column<string>(maxLength: 8, nullable: false, comment: "Abreviatura de la ocupacion"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la ocupacion"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    description = table.Column<string>(maxLength: 150, nullable: false, comment: "Descripcion de la ocupacion del servicio o tarifa"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 223, DateTimeKind.Local).AddTicks(253), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_occupation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pr_chains",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la candena del proveedor"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado del proveedor A: Activo, I: Inactivo, X: Eliminado"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 266, DateTimeKind.Local).AddTicks(2010), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pr_chains", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pr_status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del estado del proveedor"),
                    description = table.Column<string>(nullable: true, comment: "Descripcion detallada del estado del proveedor"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 270, DateTimeKind.Local).AddTicks(3519), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pr_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ra_status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del estado del proveedor"),
                    description = table.Column<string>(nullable: true, comment: "Descripcion detallada del estado del proveedor"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 295, DateTimeKind.Local).AddTicks(6404), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "se_status",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del estado del proveedor"),
                    description = table.Column<string>(nullable: true, comment: "Descripcion detallada del estado del proveedor"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 273, DateTimeKind.Local).AddTicks(3102), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_se_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "se_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del estado del proveedor"),
                    is_internal = table.Column<string>(nullable: false, defaultValue: "False", comment: "Flag para verificar si el tipo de servicio es de uso interno"),
                    IsInternal = table.Column<bool>(nullable: false),
                    CodeSetra = table.Column<string>(nullable: true),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 276, DateTimeKind.Local).AddTicks(1438), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_se_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pr_providers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    pr_chain_id = table.Column<int>(nullable: true, comment: "Llave foranea con pr_chains opcional"),
                    pr_status_id = table.Column<int>(nullable: false, comment: "Llave foranea con pr_status"),
                    ge_document_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_general"),
                    ge_country_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_locations"),
                    ge_city_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_locations"),
                    trading_name = table.Column<string>(maxLength: 120, nullable: false, comment: "Razon comercial del proveedor"),
                    legal_name = table.Column<string>(maxLength: 120, nullable: false, comment: "Razon social del proveedor"),
                    registration_number = table.Column<string>(maxLength: 30, nullable: false, comment: "Documento fiscal del proveedor"),
                    address = table.Column<string>(nullable: true, comment: "Dirección fiscal del proveedor"),
                    zip_code = table.Column<string>(maxLength: 30, nullable: true, comment: "Código postal del proveedor"),
                    phone = table.Column<string>(maxLength: 25, nullable: true, comment: "Número de telefono fiscal del proveedor"),
                    website = table.Column<string>(fixedLength: true, maxLength: 100, nullable: true, comment: "Sitio web oficial del proveedor"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 242, DateTimeKind.Local).AddTicks(6437), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pr_providers", x => x.id);
                    table.ForeignKey(
                        name: "FK_pr_providers_ge_locations_ge_city_id",
                        column: x => x.ge_city_id,
                        principalTable: "ge_locations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pr_providers_ge_locations_ge_country_id",
                        column: x => x.ge_country_id,
                        principalTable: "ge_locations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pr_providers_ge_documents_ge_document_id",
                        column: x => x.ge_document_id,
                        principalTable: "ge_documents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pr_providers_pr_chains_pr_chain_id",
                        column: x => x.pr_chain_id,
                        principalTable: "pr_chains",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_pr_providers_pr_status_pr_status_id",
                        column: x => x.pr_status_id,
                        principalTable: "pr_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "se_services",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    pr_provider_id = table.Column<int>(nullable: true, comment: "Llave foranea con pr_providers opcional"),
                    se_type_id = table.Column<int>(nullable: false, comment: "Llave foranea con se_types"),
                    se_status_id = table.Column<int>(nullable: false, comment: "Llave foranea con se_status"),
                    ge_country_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_locations"),
                    ge_city_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_locations"),
                    code = table.Column<string>(maxLength: 120, nullable: false, comment: "Codigo auto generado por el sistema"),
                    name = table.Column<string>(maxLength: 120, nullable: false, comment: "Nombre del servicio"),
                    description = table.Column<string>(maxLength: 30, nullable: false, comment: "Descripcion detallada del servicio"),
                    note = table.Column<string>(nullable: false, comment: "Notas adicionales del servicio"),
                    address = table.Column<string>(nullable: true, comment: "Dirección fiscal del proveedor"),
                    zip_code = table.Column<string>(maxLength: 30, nullable: true, comment: "Código postal del proveedor"),
                    phone = table.Column<string>(maxLength: 25, nullable: true, comment: "Número de telefono fiscal del proveedor"),
                    website = table.Column<string>(fixedLength: true, maxLength: 100, nullable: true, comment: "Sitio web oficial del proveedor"),
                    is_online_rate = table.Column<bool>(maxLength: 100, nullable: false, defaultValue: false, comment: "Flag para mostrar el servicios a clientes externos"),
                    is_preferred = table.Column<bool>(maxLength: 100, nullable: false, defaultValue: false, comment: "Flag para mostrar el servicios a clientes externos"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 287, DateTimeKind.Local).AddTicks(3929), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro"),
                    DocumentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_se_services", x => x.id);
                    table.ForeignKey(
                        name: "FK_se_services_ge_locations_ge_city_id",
                        column: x => x.ge_city_id,
                        principalTable: "ge_locations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_se_services_ge_locations_ge_country_id",
                        column: x => x.ge_country_id,
                        principalTable: "ge_locations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_se_services_ge_documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "ge_documents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_se_services_pr_providers_pr_provider_id",
                        column: x => x.pr_provider_id,
                        principalTable: "pr_providers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_se_services_se_status_se_status_id",
                        column: x => x.se_status_id,
                        principalTable: "se_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_se_services_se_types_se_type_id",
                        column: x => x.se_type_id,
                        principalTable: "se_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "se_service_details",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    se_service_id = table.Column<int>(nullable: false, comment: "Llave foranea con se_service_id"),
                    name = table.Column<string>(maxLength: 120, nullable: false, comment: "Nombre del servicio"),
                    description = table.Column<string>(maxLength: 30, nullable: false, comment: "Descripcion detallada del servicio"),
                    note = table.Column<string>(nullable: false, comment: "Notas adicionales del servicio"),
                    capacity_max = table.Column<int>(nullable: false, comment: "Capacidad maxima de personas en el servicio"),
                    capacity_max_adult = table.Column<int>(nullable: false, comment: "Capacidad maxima de adultos en el servicio"),
                    capacity_max_child = table.Column<int>(nullable: false, comment: "Capacidad maxima de niños en el servicio"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 279, DateTimeKind.Local).AddTicks(7279), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_se_service_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_se_service_details_se_services_se_service_id",
                        column: x => x.se_service_id,
                        principalTable: "se_services",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ra_rates",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    se_detail_id = table.Column<int>(nullable: false, comment: "Llave foranea con se_details"),
                    code = table.Column<string>(maxLength: 120, nullable: false, comment: "Codigo auto generado por el sistema"),
                    name = table.Column<string>(maxLength: 120, nullable: false, comment: "Nombre del servicio"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    description = table.Column<string>(maxLength: 30, nullable: false, comment: "Descripcion detallada del servicio"),
                    Link = table.Column<string>(nullable: true),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 309, DateTimeKind.Local).AddTicks(3717), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rates", x => x.id);
                    table.ForeignKey(
                        name: "FK_ra_rates_se_service_details_se_detail_id",
                        column: x => x.se_detail_id,
                        principalTable: "se_service_details",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ra_dates",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ra_rate_id = table.Column<int>(nullable: false, comment: "Llave foranea con se_details"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    travel_date_start = table.Column<DateTime>(nullable: false, comment: "Fecha de inicio de la vigencia"),
                    travel_date_end = table.Column<DateTime>(nullable: false, comment: "Fecha final de la vigencia"),
                    booking_date_end = table.Column<DateTime>(nullable: false, comment: "Fecha final para la compra"),
                    BookingDateEnd = table.Column<DateTime>(nullable: true),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 305, DateTimeKind.Local).AddTicks(6775), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_dates", x => x.id);
                    table.ForeignKey(
                        name: "FK_ra_dates_ra_rates_ra_rate_id",
                        column: x => x.ra_rate_id,
                        principalTable: "ra_rates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ra_details",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ra_date_id = table.Column<int>(nullable: false, comment: "Llave foranea con ra_date_id"),
                    ge_occupancy_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_occupancy"),
                    ge_currency_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_currency"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    cost = table.Column<decimal>(nullable: false, comment: "Costo"),
                    sale_price = table.Column<decimal>(nullable: false, comment: "Precio de venta"),
                    is_editable = table.Column<bool>(nullable: false, comment: "Flag para permitir editar los precios fuera de tarifa"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 14, 17, 15, 17, 300, DateTimeKind.Local).AddTicks(8739), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_ra_details_ge_currency_ge_currency_id",
                        column: x => x.ge_currency_id,
                        principalTable: "ge_currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ra_details_ge_occupation_ge_occupancy_id",
                        column: x => x.ge_occupancy_id,
                        principalTable: "ge_occupation",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ra_details_ra_dates_ra_date_id",
                        column: x => x.ra_date_id,
                        principalTable: "ra_dates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ge_locations_ge_location_id",
                table: "ge_locations",
                column: "ge_location_id");

            migrationBuilder.CreateIndex(
                name: "IX_pr_providers_ge_city_id",
                table: "pr_providers",
                column: "ge_city_id");

            migrationBuilder.CreateIndex(
                name: "IX_pr_providers_ge_country_id",
                table: "pr_providers",
                column: "ge_country_id");

            migrationBuilder.CreateIndex(
                name: "IX_pr_providers_ge_document_id",
                table: "pr_providers",
                column: "ge_document_id");

            migrationBuilder.CreateIndex(
                name: "IX_pr_providers_pr_chain_id",
                table: "pr_providers",
                column: "pr_chain_id");

            migrationBuilder.CreateIndex(
                name: "IX_pr_providers_pr_status_id",
                table: "pr_providers",
                column: "pr_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_pr_providers_registration_number",
                table: "pr_providers",
                column: "registration_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ra_dates_ra_rate_id",
                table: "ra_dates",
                column: "ra_rate_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_details_ge_currency_id",
                table: "ra_details",
                column: "ge_currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_details_ge_occupancy_id",
                table: "ra_details",
                column: "ge_occupancy_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_details_ra_date_id",
                table: "ra_details",
                column: "ra_date_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rates_se_detail_id",
                table: "ra_rates",
                column: "se_detail_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_service_details_se_service_id",
                table: "se_service_details",
                column: "se_service_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_services_ge_city_id",
                table: "se_services",
                column: "ge_city_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_services_ge_country_id",
                table: "se_services",
                column: "ge_country_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_services_DocumentId",
                table: "se_services",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_se_services_pr_provider_id",
                table: "se_services",
                column: "pr_provider_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_services_se_status_id",
                table: "se_services",
                column: "se_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_services_se_type_id",
                table: "se_services",
                column: "se_type_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ra_details");

            migrationBuilder.DropTable(
                name: "ra_status");

            migrationBuilder.DropTable(
                name: "ge_currency");

            migrationBuilder.DropTable(
                name: "ge_occupation");

            migrationBuilder.DropTable(
                name: "ra_dates");

            migrationBuilder.DropTable(
                name: "ra_rates");

            migrationBuilder.DropTable(
                name: "se_service_details");

            migrationBuilder.DropTable(
                name: "se_services");

            migrationBuilder.DropTable(
                name: "pr_providers");

            migrationBuilder.DropTable(
                name: "se_status");

            migrationBuilder.DropTable(
                name: "se_types");

            migrationBuilder.DropTable(
                name: "ge_locations");

            migrationBuilder.DropTable(
                name: "ge_documents");

            migrationBuilder.DropTable(
                name: "pr_chains");

            migrationBuilder.DropTable(
                name: "pr_status");
        }
    }
}
