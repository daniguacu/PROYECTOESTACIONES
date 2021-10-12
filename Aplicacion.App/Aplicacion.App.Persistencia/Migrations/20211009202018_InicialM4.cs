using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacion.App.Persistencia.Migrations
{
    public partial class InicialM4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaMontaje",
                table: "Estaciones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaMontaje",
                table: "Estaciones");
        }
    }
}
