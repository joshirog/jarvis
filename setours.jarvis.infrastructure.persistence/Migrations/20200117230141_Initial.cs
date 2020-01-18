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
                name: "co_medias",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la moneda"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 688, DateTimeKind.Local).AddTicks(8589), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_co_medias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "co_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la moneda"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 686, DateTimeKind.Local).AddTicks(7114), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_co_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_accommodations",
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 622, DateTimeKind.Local).AddTicks(1211), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_accommodations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_additionals",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del adicional"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    description = table.Column<string>(maxLength: 150, nullable: false, comment: "Descripcion detallada del concepto adicional"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 636, DateTimeKind.Local).AddTicks(7054), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_additionals", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_category_services",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la categoria del hotel o servicio"),
                    Description = table.Column<string>(nullable: true),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 649, DateTimeKind.Local).AddTicks(4916), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_category_services", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_category_setours",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la categoria de setours"),
                    Description = table.Column<string>(nullable: true),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 651, DateTimeKind.Local).AddTicks(8048), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_category_setours", x => x.id);
                });

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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 616, DateTimeKind.Local).AddTicks(7751), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_currency", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_document_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    abbreviation = table.Column<string>(maxLength: 8, nullable: false, comment: "Abreviatura del tipo de documento"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del tipo de documento"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 619, DateTimeKind.Local).AddTicks(3722), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_document_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_inclusions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la inclusion"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    description = table.Column<string>(maxLength: 150, nullable: false, comment: "Descripcion de la inclusion"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 639, DateTimeKind.Local).AddTicks(2953), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_inclusions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_languages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    abbreviature = table.Column<string>(maxLength: 5, nullable: false, comment: "Abreviatura del idioma"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del idioma"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 647, DateTimeKind.Local).AddTicks(3812), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_languages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_locations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ge_location_id = table.Column<int>(nullable: true, comment: "Llave foranea con ge_locations, recursividad - opcional"),
                    code = table.Column<string>(maxLength: 5, nullable: false, comment: "Codigo de la ubicacion"),
                    type = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, comment: "Tipo de ubigeo P: Pais, C: Ciudad"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la ubicacion"),
                    is_destination = table.Column<bool>(nullable: false, defaultValue: false, comment: "Indicador para verificar si es un destino de servicio"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 627, DateTimeKind.Local).AddTicks(914), comment: "Fecha de generacion el registro"),
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
                name: "ge_restriction_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<string>(maxLength: 8, nullable: false, comment: "Codigo del mercado"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del mercado"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 641, DateTimeKind.Local).AddTicks(8636), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_restriction_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_segmentation_markets",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la segmentacion de mercado o cliente"),
                    Description = table.Column<string>(nullable: true),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 610, DateTimeKind.Local).AddTicks(8478), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_segmentation_markets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_service_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del estado del proveedor"),
                    description = table.Column<string>(nullable: true, comment: "Descripcion detallada del estado del proveedor"),
                    is_internal = table.Column<bool>(nullable: false, defaultValue: false, comment: "Flag para verificar si el tipo de servicio es de uso interno"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 644, DateTimeKind.Local).AddTicks(7192), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_service_types", x => x.id);
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 678, DateTimeKind.Local).AddTicks(4146), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 680, DateTimeKind.Local).AddTicks(6548), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 726, DateTimeKind.Local).AddTicks(9368), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 700, DateTimeKind.Local).AddTicks(8464), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_se_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ta_taxes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    abbreviation = table.Column<string>(maxLength: 10, nullable: false, comment: "Abreviatura del tipo de impuesto"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del tipo de impuesto"),
                    description = table.Column<string>(nullable: true, comment: "Description del tipo de impuesto"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 654, DateTimeKind.Local).AddTicks(6045), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ta_taxes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "co_contacts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    co_type_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla co_types"),
                    title = table.Column<string>(maxLength: 150, nullable: false, comment: "Cargo o titulo del contacto"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del contacto"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    is_notifiable = table.Column<bool>(nullable: false, defaultValue: false, comment: "Habilidado enviar notificaciones o correos al contacto"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 692, DateTimeKind.Local).AddTicks(3342), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_co_contacts", x => x.id);
                    table.ForeignKey(
                        name: "FK_co_contacts_co_types_co_type_id",
                        column: x => x.co_type_id,
                        principalTable: "co_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    partner_zone_username = table.Column<string>(fixedLength: true, maxLength: 100, nullable: true, comment: "Credencial como agente del proveedor"),
                    partner_zone_password = table.Column<string>(fixedLength: true, maxLength: 100, nullable: true, comment: "Credencial como agente del proveedor"),
                    partner_zone_link = table.Column<string>(fixedLength: true, maxLength: 100, nullable: true, comment: "Sitio web como agente del proveedor"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 665, DateTimeKind.Local).AddTicks(4182), comment: "Fecha de generacion el registro"),
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
                        name: "FK_pr_providers_ge_document_types_ge_document_id",
                        column: x => x.ge_document_id,
                        principalTable: "ge_document_types",
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
                name: "ta_tax_details",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ta_tax_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla ta_taxes"),
                    ge_country_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla ge_locations"),
                    value = table.Column<decimal>(nullable: false, comment: "Valor del impuesto"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 658, DateTimeKind.Local).AddTicks(3969), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ta_tax_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_ta_tax_details_ge_locations_ge_country_id",
                        column: x => x.ge_country_id,
                        principalTable: "ge_locations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ta_tax_details_ta_taxes_ta_tax_id",
                        column: x => x.ta_tax_id,
                        principalTable: "ta_taxes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "co_contact_data",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    co_contact_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla co_contacts"),
                    co_media_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla co_medias"),
                    value = table.Column<string>(nullable: false, comment: "valor del datos ingresado"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 697, DateTimeKind.Local).AddTicks(9304), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_co_contact_data", x => x.id);
                    table.ForeignKey(
                        name: "FK_co_contact_data_co_contacts_co_contact_id",
                        column: x => x.co_contact_id,
                        principalTable: "co_contacts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_co_contact_data_co_medias_co_media_id",
                        column: x => x.co_media_id,
                        principalTable: "co_medias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "co_contact_details",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    co_contact_id = table.Column<int>(maxLength: 150, nullable: false, comment: "Llave foranea con co_contacts"),
                    name = table.Column<int>(maxLength: 150, nullable: false, comment: "Llave foranea con ge_segmentations"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 695, DateTimeKind.Local).AddTicks(218), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro"),
                    SegmentationMarketId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_co_contact_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_co_contact_details_co_contacts_co_contact_id",
                        column: x => x.co_contact_id,
                        principalTable: "co_contacts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_co_contact_details_ge_segmentation_markets_SegmentationMark~",
                        column: x => x.SegmentationMarketId,
                        principalTable: "ge_segmentation_markets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pr_provider_contacts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    pr_provider_id = table.Column<int>(nullable: false, comment: "Llave foranea con tabla pr_providers"),
                    co_contact_id = table.Column<int>(nullable: false, comment: "Llave foranea con tabla co_contacts"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 683, DateTimeKind.Local).AddTicks(6203), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pr_provider_contacts", x => x.id);
                    table.ForeignKey(
                        name: "FK_pr_provider_contacts_co_contacts_co_contact_id",
                        column: x => x.co_contact_id,
                        principalTable: "co_contacts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pr_provider_contacts_pr_providers_pr_provider_id",
                        column: x => x.pr_provider_id,
                        principalTable: "pr_providers",
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
                    ge_category_service_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_category_services"),
                    ge_category_setours_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_category_setours"),
                    code = table.Column<string>(maxLength: 120, nullable: false, comment: "Codigo auto generado por el sistema"),
                    name = table.Column<string>(maxLength: 120, nullable: false, comment: "Nombre del servicio"),
                    note = table.Column<string>(nullable: false, comment: "Notas adicionales del servicio"),
                    address = table.Column<string>(nullable: true, comment: "Dirección fiscal del proveedor"),
                    zip_code = table.Column<string>(maxLength: 30, nullable: true, comment: "Código postal del proveedor"),
                    phone = table.Column<string>(maxLength: 25, nullable: true, comment: "Número de telefono fiscal del proveedor"),
                    website = table.Column<string>(fixedLength: true, maxLength: 100, nullable: true, comment: "Sitio web oficial del proveedor"),
                    is_online_rate = table.Column<bool>(nullable: false, defaultValue: false, comment: "Flag para mostrar el servicios a clientes externos"),
                    is_preferred = table.Column<bool>(nullable: false, defaultValue: false, comment: "Flag para mostrar el servicios a clientes externos"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 712, DateTimeKind.Local).AddTicks(135), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_se_services", x => x.id);
                    table.ForeignKey(
                        name: "FK_se_services_ge_category_services_ge_category_service_id",
                        column: x => x.ge_category_service_id,
                        principalTable: "ge_category_services",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_se_services_ge_category_setours_ge_category_setours_id",
                        column: x => x.ge_category_setours_id,
                        principalTable: "ge_category_setours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_se_services_ge_service_types_se_type_id",
                        column: x => x.se_type_id,
                        principalTable: "ge_service_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "se_service_descriptions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    se_service_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla se_services"),
                    ge_language_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla ge_languages"),
                    Value = table.Column<string>(nullable: true),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 724, DateTimeKind.Local).AddTicks(6233), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_se_service_descriptions", x => x.id);
                    table.ForeignKey(
                        name: "FK_se_service_descriptions_ge_languages_ge_language_id",
                        column: x => x.ge_language_id,
                        principalTable: "ge_languages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_se_service_descriptions_se_services_se_service_id",
                        column: x => x.se_service_id,
                        principalTable: "se_services",
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
                    age_max_child = table.Column<int>(nullable: false, comment: "Edad maxima para el niño"),
                    is_extra_cost_child = table.Column<bool>(nullable: false, defaultValue: false, comment: "Flag para agregar el costo extra para el niño"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 704, DateTimeKind.Local).AddTicks(7628), comment: "Fecha de generacion el registro"),
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
                    ge_market_type_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla ge_market_types"),
                    ra_status_id = table.Column<int>(nullable: false, comment: "Llave foranea con ra_status"),
                    code = table.Column<string>(maxLength: 120, nullable: false, comment: "Codigo auto generado por el sistema"),
                    name = table.Column<string>(maxLength: 120, nullable: false, comment: "Nombre del servicio"),
                    ge_currency_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_currency"),
                    description = table.Column<string>(maxLength: 30, nullable: false, comment: "Descripcion detallada del servicio"),
                    estimated = table.Column<decimal>(nullable: false, comment: "Margen de estimacion o preyeccion"),
                    link = table.Column<string>(nullable: true, comment: "Link de enlace al documento de tarifa del proveedor"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 739, DateTimeKind.Local).AddTicks(8543), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rates", x => x.id);
                    table.ForeignKey(
                        name: "FK_ra_rates_ge_currency_ge_currency_id",
                        column: x => x.ge_currency_id,
                        principalTable: "ge_currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ra_rates_ra_status_ra_status_id",
                        column: x => x.ra_status_id,
                        principalTable: "ra_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ra_rates_ge_restriction_types_ge_market_type_id",
                        column: x => x.ge_market_type_id,
                        principalTable: "ge_restriction_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ra_rates_se_service_details_se_detail_id",
                        column: x => x.se_detail_id,
                        principalTable: "se_service_details",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "se_service_detail_additionals",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    se_detail_id = table.Column<int>(nullable: false, comment: "Llave foranea con tabla se_details"),
                    ge_additional_id = table.Column<int>(nullable: false, comment: "Llave foranea con tabla ge_additionals"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 721, DateTimeKind.Local).AddTicks(6113), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_se_service_detail_additionals", x => x.id);
                    table.ForeignKey(
                        name: "FK_se_service_detail_additionals_ge_additionals_ge_additional_~",
                        column: x => x.ge_additional_id,
                        principalTable: "ge_additionals",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_se_service_detail_additionals_se_service_details_se_detail_~",
                        column: x => x.se_detail_id,
                        principalTable: "se_service_details",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ra_rate_dates",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ra_rate_id = table.Column<int>(nullable: false, comment: "Llave foranea con se_details"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    travel_date_start = table.Column<DateTime>(nullable: false, comment: "Fecha de inicio de la vigencia"),
                    travel_date_end = table.Column<DateTime>(nullable: false, comment: "Fecha final de la vigencia"),
                    booking_date_start = table.Column<DateTime>(nullable: false, comment: "Fecha de inicio para la compra"),
                    booking_date_end = table.Column<DateTime>(nullable: false, comment: "Fecha final para la compra"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 734, DateTimeKind.Local).AddTicks(8657), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rate_dates", x => x.id);
                    table.ForeignKey(
                        name: "FK_ra_rate_dates_ra_rates_ra_rate_id",
                        column: x => x.ra_rate_id,
                        principalTable: "ra_rates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ra_rate_inclusions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ra_rate_id = table.Column<int>(nullable: false, comment: "Llave foranea con ra_rates"),
                    ge_inclusion_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_inclusions"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 752, DateTimeKind.Local).AddTicks(4368), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rate_inclusions", x => x.id);
                    table.ForeignKey(
                        name: "FK_ra_rate_inclusions_ge_inclusions_ge_inclusion_id",
                        column: x => x.ge_inclusion_id,
                        principalTable: "ge_inclusions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ra_rate_inclusions_ra_rates_ra_rate_id",
                        column: x => x.ra_rate_id,
                        principalTable: "ra_rates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ra_rate_taxes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ra_rate_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla ra_rates"),
                    ta_tax_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla ta_taxes"),
                    value = table.Column<decimal>(nullable: false, comment: "Valor del impuesto"),
                    is_included = table.Column<bool>(nullable: false, comment: "Indicador para verificar si el impuesto esta incluido"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 756, DateTimeKind.Local).AddTicks(6409), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rate_taxes", x => x.id);
                    table.ForeignKey(
                        name: "FK_ra_rate_taxes_ra_rates_ra_rate_id",
                        column: x => x.ra_rate_id,
                        principalTable: "ra_rates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ra_rate_taxes_ta_taxes_ta_tax_id",
                        column: x => x.ta_tax_id,
                        principalTable: "ta_taxes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ra_rate_date_blackouts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ra_rate_date_id = table.Column<int>(nullable: false, comment: "Llave foranea con se_details"),
                    data_in = table.Column<DateTime>(nullable: false, comment: "Blackout fecha inicio"),
                    data_out = table.Column<DateTime>(nullable: false, comment: "Blackout fecha final"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 749, DateTimeKind.Local).AddTicks(670), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rate_date_blackouts", x => x.id);
                    table.ForeignKey(
                        name: "FK_ra_rate_date_blackouts_ra_rate_dates_ra_rate_date_id",
                        column: x => x.ra_rate_date_id,
                        principalTable: "ra_rate_dates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ra_rate_days",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ra_rate_id = table.Column<int>(nullable: false, comment: "Llave foranea con ra_rates"),
                    num_day = table.Column<int>(nullable: false, comment: "Número de día de la semana"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 743, DateTimeKind.Local).AddTicks(9996), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rate_days", x => x.id);
                    table.ForeignKey(
                        name: "FK_ra_rate_days_ra_rate_dates_ra_rate_id",
                        column: x => x.ra_rate_id,
                        principalTable: "ra_rate_dates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ra_rate_details",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ra_date_id = table.Column<int>(nullable: false, comment: "Llave foranea con ra_date_id"),
                    ge_accommodation_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_accommodations"),
                    CurrencyId = table.Column<int>(nullable: false),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    cost = table.Column<decimal>(nullable: false, comment: "Costo"),
                    sale_price = table.Column<decimal>(nullable: false, comment: "Precio de venta"),
                    Margin = table.Column<decimal>(nullable: false),
                    Estimated = table.Column<decimal>(nullable: false),
                    is_editable = table.Column<bool>(nullable: false, comment: "Flag para permitir editar los precios fuera de tarifa"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 17, 18, 1, 40, 730, DateTimeKind.Local).AddTicks(7539), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro"),
                    CurrencyEntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rate_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_ra_rate_details_ge_accommodations_ge_accommodation_id",
                        column: x => x.ge_accommodation_id,
                        principalTable: "ge_accommodations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ra_rate_details_ge_currency_CurrencyEntityId",
                        column: x => x.CurrencyEntityId,
                        principalTable: "ge_currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ra_rate_details_ra_rate_dates_ra_date_id",
                        column: x => x.ra_date_id,
                        principalTable: "ra_rate_dates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_co_contact_data_co_contact_id",
                table: "co_contact_data",
                column: "co_contact_id");

            migrationBuilder.CreateIndex(
                name: "IX_co_contact_data_co_media_id",
                table: "co_contact_data",
                column: "co_media_id");

            migrationBuilder.CreateIndex(
                name: "IX_co_contact_details_co_contact_id",
                table: "co_contact_details",
                column: "co_contact_id");

            migrationBuilder.CreateIndex(
                name: "IX_co_contact_details_SegmentationMarketId",
                table: "co_contact_details",
                column: "SegmentationMarketId");

            migrationBuilder.CreateIndex(
                name: "IX_co_contacts_co_type_id",
                table: "co_contacts",
                column: "co_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_ge_locations_ge_location_id",
                table: "ge_locations",
                column: "ge_location_id");

            migrationBuilder.CreateIndex(
                name: "IX_pr_provider_contacts_co_contact_id",
                table: "pr_provider_contacts",
                column: "co_contact_id");

            migrationBuilder.CreateIndex(
                name: "IX_pr_provider_contacts_pr_provider_id",
                table: "pr_provider_contacts",
                column: "pr_provider_id");

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
                name: "IX_ra_rate_date_blackouts_ra_rate_date_id",
                table: "ra_rate_date_blackouts",
                column: "ra_rate_date_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_dates_ra_rate_id",
                table: "ra_rate_dates",
                column: "ra_rate_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_days_ra_rate_id",
                table: "ra_rate_days",
                column: "ra_rate_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_details_ge_accommodation_id",
                table: "ra_rate_details",
                column: "ge_accommodation_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_details_CurrencyEntityId",
                table: "ra_rate_details",
                column: "CurrencyEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_details_ra_date_id",
                table: "ra_rate_details",
                column: "ra_date_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_inclusions_ge_inclusion_id",
                table: "ra_rate_inclusions",
                column: "ge_inclusion_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_inclusions_ra_rate_id",
                table: "ra_rate_inclusions",
                column: "ra_rate_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_taxes_ra_rate_id",
                table: "ra_rate_taxes",
                column: "ra_rate_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_taxes_ta_tax_id",
                table: "ra_rate_taxes",
                column: "ta_tax_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rates_ge_currency_id",
                table: "ra_rates",
                column: "ge_currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rates_ra_status_id",
                table: "ra_rates",
                column: "ra_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rates_ge_market_type_id",
                table: "ra_rates",
                column: "ge_market_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rates_se_detail_id",
                table: "ra_rates",
                column: "se_detail_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_service_descriptions_ge_language_id",
                table: "se_service_descriptions",
                column: "ge_language_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_service_descriptions_se_service_id",
                table: "se_service_descriptions",
                column: "se_service_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_service_detail_additionals_ge_additional_id",
                table: "se_service_detail_additionals",
                column: "ge_additional_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_service_detail_additionals_se_detail_id",
                table: "se_service_detail_additionals",
                column: "se_detail_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_service_details_se_service_id",
                table: "se_service_details",
                column: "se_service_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_services_ge_category_service_id",
                table: "se_services",
                column: "ge_category_service_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_services_ge_category_setours_id",
                table: "se_services",
                column: "ge_category_setours_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_services_ge_city_id",
                table: "se_services",
                column: "ge_city_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_services_ge_country_id",
                table: "se_services",
                column: "ge_country_id");

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

            migrationBuilder.CreateIndex(
                name: "IX_ta_tax_details_ge_country_id",
                table: "ta_tax_details",
                column: "ge_country_id");

            migrationBuilder.CreateIndex(
                name: "IX_ta_tax_details_ta_tax_id",
                table: "ta_tax_details",
                column: "ta_tax_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "co_contact_data");

            migrationBuilder.DropTable(
                name: "co_contact_details");

            migrationBuilder.DropTable(
                name: "pr_provider_contacts");

            migrationBuilder.DropTable(
                name: "ra_rate_date_blackouts");

            migrationBuilder.DropTable(
                name: "ra_rate_days");

            migrationBuilder.DropTable(
                name: "ra_rate_details");

            migrationBuilder.DropTable(
                name: "ra_rate_inclusions");

            migrationBuilder.DropTable(
                name: "ra_rate_taxes");

            migrationBuilder.DropTable(
                name: "se_service_descriptions");

            migrationBuilder.DropTable(
                name: "se_service_detail_additionals");

            migrationBuilder.DropTable(
                name: "ta_tax_details");

            migrationBuilder.DropTable(
                name: "co_medias");

            migrationBuilder.DropTable(
                name: "ge_segmentation_markets");

            migrationBuilder.DropTable(
                name: "co_contacts");

            migrationBuilder.DropTable(
                name: "ge_accommodations");

            migrationBuilder.DropTable(
                name: "ra_rate_dates");

            migrationBuilder.DropTable(
                name: "ge_inclusions");

            migrationBuilder.DropTable(
                name: "ge_languages");

            migrationBuilder.DropTable(
                name: "ge_additionals");

            migrationBuilder.DropTable(
                name: "ta_taxes");

            migrationBuilder.DropTable(
                name: "co_types");

            migrationBuilder.DropTable(
                name: "ra_rates");

            migrationBuilder.DropTable(
                name: "ge_currency");

            migrationBuilder.DropTable(
                name: "ra_status");

            migrationBuilder.DropTable(
                name: "ge_restriction_types");

            migrationBuilder.DropTable(
                name: "se_service_details");

            migrationBuilder.DropTable(
                name: "se_services");

            migrationBuilder.DropTable(
                name: "ge_category_services");

            migrationBuilder.DropTable(
                name: "ge_category_setours");

            migrationBuilder.DropTable(
                name: "pr_providers");

            migrationBuilder.DropTable(
                name: "se_status");

            migrationBuilder.DropTable(
                name: "ge_service_types");

            migrationBuilder.DropTable(
                name: "ge_locations");

            migrationBuilder.DropTable(
                name: "ge_document_types");

            migrationBuilder.DropTable(
                name: "pr_chains");

            migrationBuilder.DropTable(
                name: "pr_status");
        }
    }
}
