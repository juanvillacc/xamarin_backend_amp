using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmpApi.API.Migrations
{
    public partial class AgregarCiudad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_ciudad",
                table: "Suscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_ciudad",
                table: "Suscripciones");
        }
    }
}
