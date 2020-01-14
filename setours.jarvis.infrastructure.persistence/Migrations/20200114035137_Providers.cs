using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace setours.jarvis.infrastructure.persistence.Migrations
{
    public partial class Providers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 13, 22, 51, 37, 453, DateTimeKind.Local).AddTicks(1040), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 13, 22, 51, 37, 478, DateTimeKind.Local).AddTicks(3860), comment: "Fecha de generacion el registro"),
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
                name: "pr_chains",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false, comment: "Llave primaria de la tabla")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false, comment: "Nombre de la candena del proveedor"),
                    status = table.Column<string>(fixedLength: true, maxLength: 1, nullable: false, defaultValue: "A", comment: "Estado del proveedor A: Activo, I: Inactivo, X: Eliminado"),
                    code_setra = table.Column<string>(maxLength: 20, nullable: true, comment: "Llave primaria del sistema version 1"),
                    created_by = table.Column<string>(maxLength: 50, nullable: false, comment: "Usuario que genero el registro"),
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 13, 22, 51, 37, 502, DateTimeKind.Local).AddTicks(590), comment: "Fecha de generacion el registro"),
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 13, 22, 51, 37, 505, DateTimeKind.Local).AddTicks(8280), comment: "Fecha de generacion el registro"),
                    updated_by = table.Column<string>(maxLength: 50, nullable: true, comment: "Ultimo usuario que actualizo el registro"),
                    updated_at = table.Column<DateTime>(nullable: true, comment: "Ultima fecha de actualizacion el registro")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pr_status", x => x.id);
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
                    created_at = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 13, 22, 51, 37, 491, DateTimeKind.Local).AddTicks(1590), comment: "Fecha de generacion el registro"),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pr_providers");

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
