using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class relacionoVendedorConSucursal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SucursalId",
                table: "Vendedor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_SucursalId",
                table: "Vendedor",
                column: "SucursalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Sucursal_SucursalId",
                table: "Vendedor",
                column: "SucursalId",
                principalTable: "Sucursal",
                principalColumn: "SucursalId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Sucursal_SucursalId",
                table: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Vendedor_SucursalId",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "SucursalId",
                table: "Vendedor");
        }
    }
}
