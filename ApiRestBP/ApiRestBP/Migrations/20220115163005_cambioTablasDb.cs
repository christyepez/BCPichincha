using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiRestBP.Migrations
{
    public partial class cambioTablasDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Movimientos");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Cuentas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Cuentas");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Movimientos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
