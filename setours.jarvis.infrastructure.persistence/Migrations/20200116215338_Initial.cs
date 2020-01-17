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
                name: "cl_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del tipo de cliente"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 231, DateTimeKind.Local).AddTicks(7173), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cl_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "co_medias",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la moneda"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 235, DateTimeKind.Local).AddTicks(9623), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 233, DateTimeKind.Local).AddTicks(8418), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 180, DateTimeKind.Local).AddTicks(14), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 193, DateTimeKind.Local).AddTicks(7133), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_additionals", x => x.id);
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 174, DateTimeKind.Local).AddTicks(8519), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 177, DateTimeKind.Local).AddTicks(3659), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_documents", x => x.id);
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 196, DateTimeKind.Local).AddTicks(2313), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_inclusions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_locations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ge_location_id = table.Column<int>(nullable: true, comment: "Llave foranea con ge_locations, recursividad - opcional"),
                    type = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, comment: "Tipo de ubigeo P: Pais, C: Ciudad"),
                    code = table.Column<string>(maxLength: 5, nullable: false, comment: "Codigo de la ubicacion"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la ubicacion"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 183, DateTimeKind.Local).AddTicks(9979), comment: "Fecha de generacion el registro"),
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
                name: "ge_markets",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<string>(maxLength: 8, nullable: false, comment: "Codigo del mercado"),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre del mercado"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 198, DateTimeKind.Local).AddTicks(7839), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_markets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ge_segmentations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la segmentacion de mercado"),
                    description = table.Column<string>(maxLength: 150, nullable: true, comment: "Descripcion detallada de la segmentacion de mercado"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 168, DateTimeKind.Local).AddTicks(118), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ge_segmentations", x => x.id);
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 223, DateTimeKind.Local).AddTicks(2071), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 225, DateTimeKind.Local).AddTicks(4867), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pr_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ra_rate_blackouts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ra_rate_id = table.Column<int>(nullable: false, comment: "Llave foranea con se_details"),
                    data_in = table.Column<DateTime>(nullable: false, comment: "Blackout fecha in"),
                    data_out = table.Column<DateTime>(nullable: false, comment: "Blackout fecha out"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 291, DateTimeKind.Local).AddTicks(5216), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rate_blackouts", x => x.id);
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 289, DateTimeKind.Local).AddTicks(1200), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rate_days", x => x.id);
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 293, DateTimeKind.Local).AddTicks(7236), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rate_inclusions", x => x.id);
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 296, DateTimeKind.Local).AddTicks(4818), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rate_taxes", x => x.id);
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 272, DateTimeKind.Local).AddTicks(8578), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 248, DateTimeKind.Local).AddTicks(7505), comment: "Fecha de generacion el registro"),
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
                    description = table.Column<string>(nullable: true, comment: "Descripcion detallada del estado del proveedor"),
                    is_internal = table.Column<bool>(nullable: false, defaultValue: false, comment: "Flag para verificar si el tipo de servicio es de uso interno"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 251, DateTimeKind.Local).AddTicks(5248), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_se_types", x => x.id);
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 201, DateTimeKind.Local).AddTicks(1026), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 239, DateTimeKind.Local).AddTicks(9024), comment: "Fecha de generacion el registro"),
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
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 211, DateTimeKind.Local).AddTicks(624), comment: "Fecha de generacion el registro"),
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
                name: "ta_tax_details",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ta_tax_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla ta_taxes"),
                    ge_country_id = table.Column<int>(nullable: false, comment: "Llave foranea con la tabla ge_locations"),
                    value = table.Column<decimal>(nullable: false, comment: "Valor del impuesto"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 204, DateTimeKind.Local).AddTicks(6186), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 245, DateTimeKind.Local).AddTicks(7475), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 242, DateTimeKind.Local).AddTicks(6895), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
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
                        name: "FK_co_contact_details_ge_segmentations_name",
                        column: x => x.name,
                        principalTable: "ge_segmentations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 228, DateTimeKind.Local).AddTicks(2654), comment: "Fecha de generacion el registro"),
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
                    code = table.Column<string>(maxLength: 120, nullable: false, comment: "Codigo auto generado por el sistema"),
                    name = table.Column<string>(maxLength: 120, nullable: false, comment: "Nombre del servicio"),
                    description = table.Column<string>(maxLength: 30, nullable: false, comment: "Descripcion detallada del servicio"),
                    note = table.Column<string>(nullable: false, comment: "Notas adicionales del servicio"),
                    address = table.Column<string>(nullable: true, comment: "Dirección fiscal del proveedor"),
                    zip_code = table.Column<string>(maxLength: 30, nullable: true, comment: "Código postal del proveedor"),
                    phone = table.Column<string>(maxLength: 25, nullable: true, comment: "Número de telefono fiscal del proveedor"),
                    website = table.Column<string>(fixedLength: true, maxLength: 100, nullable: true, comment: "Sitio web oficial del proveedor"),
                    is_online_rate = table.Column<bool>(nullable: false, defaultValue: false, comment: "Flag para mostrar el servicios a clientes externos"),
                    is_preferred = table.Column<bool>(nullable: false, defaultValue: false, comment: "Flag para mostrar el servicios a clientes externos"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 262, DateTimeKind.Local).AddTicks(892), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
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
                name: "se_details",
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 255, DateTimeKind.Local).AddTicks(5833), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_se_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_se_details_se_services_se_service_id",
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
                    ra_status_id = table.Column<int>(nullable: false, comment: "Llave foranea con ra_status"),
                    code = table.Column<string>(maxLength: 120, nullable: false, comment: "Codigo auto generado por el sistema"),
                    name = table.Column<string>(maxLength: 120, nullable: false, comment: "Nombre del servicio"),
                    description = table.Column<string>(maxLength: 30, nullable: false, comment: "Descripcion detallada del servicio"),
                    link = table.Column<string>(nullable: true, comment: "Link de enlace al documento de tarifa del proveedor"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 286, DateTimeKind.Local).AddTicks(1607), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ra_rates", x => x.id);
                    table.ForeignKey(
                        name: "FK_ra_rates_ra_status_ra_status_id",
                        column: x => x.ra_status_id,
                        principalTable: "ra_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ra_rates_se_details_se_detail_id",
                        column: x => x.se_detail_id,
                        principalTable: "se_details",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "se_detail_additionals",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    se_detail_id = table.Column<int>(nullable: false, comment: "Llave foranea con tabla se_details"),
                    ge_additional_id = table.Column<int>(nullable: false, comment: "Llave foranea con tabla ge_additionals"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 269, DateTimeKind.Local).AddTicks(8839), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_se_detail_additionals", x => x.id);
                    table.ForeignKey(
                        name: "FK_se_detail_additionals_ge_additionals_ge_additional_id",
                        column: x => x.ge_additional_id,
                        principalTable: "ge_additionals",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_se_detail_additionals_se_details_se_detail_id",
                        column: x => x.se_detail_id,
                        principalTable: "se_details",
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 282, DateTimeKind.Local).AddTicks(2556), comment: "Fecha de generacion el registro"),
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
                name: "ra_rate_details",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ra_date_id = table.Column<int>(nullable: false, comment: "Llave foranea con ra_date_id"),
                    ge_accommodation_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_accommodations"),
                    ge_currency_id = table.Column<int>(nullable: false, comment: "Llave foranea con ge_currency"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado A: Activo, I: Inactivo, X: Eliminado"),
                    cost = table.Column<decimal>(nullable: false, comment: "Costo"),
                    sale_price = table.Column<decimal>(nullable: false, comment: "Precio de venta"),
                    Margin = table.Column<decimal>(nullable: false),
                    estimated = table.Column<decimal>(nullable: false, comment: "Margen de estimacion o preyeccion"),
                    is_editable = table.Column<bool>(nullable: false, comment: "Flag para permitir editar los precios fuera de tarifa"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 16, 16, 53, 38, 277, DateTimeKind.Local).AddTicks(6209), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "ultima fecha de actualizacion el registro")
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
                        name: "FK_ra_rate_details_ge_currency_ge_currency_id",
                        column: x => x.ge_currency_id,
                        principalTable: "ge_currency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_co_contact_details_name",
                table: "co_contact_details",
                column: "name");

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
                name: "IX_ra_rate_dates_ra_rate_id",
                table: "ra_rate_dates",
                column: "ra_rate_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_details_ge_accommodation_id",
                table: "ra_rate_details",
                column: "ge_accommodation_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_details_ge_currency_id",
                table: "ra_rate_details",
                column: "ge_currency_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rate_details_ra_date_id",
                table: "ra_rate_details",
                column: "ra_date_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rates_ra_status_id",
                table: "ra_rates",
                column: "ra_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_ra_rates_se_detail_id",
                table: "ra_rates",
                column: "se_detail_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_detail_additionals_ge_additional_id",
                table: "se_detail_additionals",
                column: "ge_additional_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_detail_additionals_se_detail_id",
                table: "se_detail_additionals",
                column: "se_detail_id");

            migrationBuilder.CreateIndex(
                name: "IX_se_details_se_service_id",
                table: "se_details",
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
                name: "cl_types");

            migrationBuilder.DropTable(
                name: "co_contact_data");

            migrationBuilder.DropTable(
                name: "co_contact_details");

            migrationBuilder.DropTable(
                name: "ge_inclusions");

            migrationBuilder.DropTable(
                name: "ge_markets");

            migrationBuilder.DropTable(
                name: "pr_provider_contacts");

            migrationBuilder.DropTable(
                name: "ra_rate_blackouts");

            migrationBuilder.DropTable(
                name: "ra_rate_days");

            migrationBuilder.DropTable(
                name: "ra_rate_details");

            migrationBuilder.DropTable(
                name: "ra_rate_inclusions");

            migrationBuilder.DropTable(
                name: "ra_rate_taxes");

            migrationBuilder.DropTable(
                name: "se_detail_additionals");

            migrationBuilder.DropTable(
                name: "ta_tax_details");

            migrationBuilder.DropTable(
                name: "co_medias");

            migrationBuilder.DropTable(
                name: "ge_segmentations");

            migrationBuilder.DropTable(
                name: "co_contacts");

            migrationBuilder.DropTable(
                name: "ge_accommodations");

            migrationBuilder.DropTable(
                name: "ge_currency");

            migrationBuilder.DropTable(
                name: "ra_rate_dates");

            migrationBuilder.DropTable(
                name: "ge_additionals");

            migrationBuilder.DropTable(
                name: "ta_taxes");

            migrationBuilder.DropTable(
                name: "co_types");

            migrationBuilder.DropTable(
                name: "ra_rates");

            migrationBuilder.DropTable(
                name: "ra_status");

            migrationBuilder.DropTable(
                name: "se_details");

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
