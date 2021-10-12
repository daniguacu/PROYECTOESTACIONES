using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacion.App.Persistencia.Migrations
{
    public partial class InicialM3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Latitutd",
                table: "Estaciones",
                newName: "Latitud");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Latitud",
                table: "Estaciones",
                newName: "Latitutd");
        }
    }
}
