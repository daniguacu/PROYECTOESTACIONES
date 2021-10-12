using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacion.App.Persistencia.Migrations
{
    public partial class InicialM1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estaciones_Personas_TecnicoId",
                table: "Estaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Estaciones_Reporte_ReporteId",
                table: "Estaciones");

            migrationBuilder.DropTable(
                name: "DataMeteorologico");

            migrationBuilder.DropTable(
                name: "Reporte");

            migrationBuilder.DropIndex(
                name: "IX_Estaciones_ReporteId",
                table: "Estaciones");

            migrationBuilder.DropIndex(
                name: "IX_Estaciones_TecnicoId",
                table: "Estaciones");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FechaMontaje",
                table: "Estaciones");

            migrationBuilder.DropColumn(
                name: "ReporteId",
                table: "Estaciones");

            migrationBuilder.DropColumn(
                name: "TecnicoId",
                table: "Estaciones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaMontaje",
                table: "Estaciones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ReporteId",
                table: "Estaciones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TecnicoId",
                table: "Estaciones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DataMeteorologico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstacionId = table.Column<int>(type: "int", nullable: true),
                    FechaDato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoDato = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataMeteorologico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataMeteorologico_Estaciones_EstacionId",
                        column: x => x.EstacionId,
                        principalTable: "Estaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reporte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporte", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estaciones_ReporteId",
                table: "Estaciones",
                column: "ReporteId");

            migrationBuilder.CreateIndex(
                name: "IX_Estaciones_TecnicoId",
                table: "Estaciones",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_DataMeteorologico_EstacionId",
                table: "DataMeteorologico",
                column: "EstacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estaciones_Personas_TecnicoId",
                table: "Estaciones",
                column: "TecnicoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estaciones_Reporte_ReporteId",
                table: "Estaciones",
                column: "ReporteId",
                principalTable: "Reporte",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
