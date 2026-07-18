using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class AjustesFinalesModelo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Monto",
                table: "Descuentos",
                newName: "Valor");

            migrationBuilder.AddColumn<int>(
                name: "DescuentoId",
                table: "Ventas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MontoDescuento",
                table: "Ventas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioUnitario",
                table: "DetallesVenta",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_DescuentoId",
                table: "Ventas",
                column: "DescuentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Descuentos_DescuentoId",
                table: "Ventas",
                column: "DescuentoId",
                principalTable: "Descuentos",
                principalColumn: "DescuentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Descuentos_DescuentoId",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_DescuentoId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "DescuentoId",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "MontoDescuento",
                table: "Ventas");

            migrationBuilder.DropColumn(
                name: "PrecioUnitario",
                table: "DetallesVenta");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Descuentos",
                newName: "Monto");
        }
    }
}
