using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiRestBP.Migrations
{
    public partial class AgregarUserDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movimientos",
                table: "Movimientos");

            migrationBuilder.RenameTable(
                name: "Movimientos",
                newName: "Movimiento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movimiento",
                table: "Movimiento",
                column: "MovimientoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movimiento",
                table: "Movimiento");

            migrationBuilder.RenameTable(
                name: "Movimiento",
                newName: "Movimientos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movimientos",
                table: "Movimientos",
                column: "MovimientoId");
        }
    }
}
