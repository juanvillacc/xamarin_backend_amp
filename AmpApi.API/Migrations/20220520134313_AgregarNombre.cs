using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmpApi.API.Migrations
{
    public partial class AgregarNombre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nombres",
                table: "Suscripciones",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nombres",
                table: "Suscripciones");
        }
    }
}
