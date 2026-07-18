using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class AgregueTavblaTiposCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoCliente",
                table: "Descuentos",
                newName: "TipoClienteId");

            migrationBuilder.RenameColumn(
                name: "TipoDeCliente",
                table: "Clientes",
                newName: "TipoClienteId");

            migrationBuilder.CreateTable(
                name: "TiposClientes",
                columns: table => new
                {
                    TipoClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposClientes", x => x.TipoClienteId);
                });

            migrationBuilder.InsertData(
                table: "TiposClientes",
                columns: new[] { "TipoClienteId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Mayorista" },
                    { 2, "Minorista" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Descuentos_TipoClienteId",
                table: "Descuentos",
                column: "TipoClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoClienteId",
                table: "Clientes",
                column: "TipoClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_TiposClientes_TipoClienteId",
                table: "Clientes",
                column: "TipoClienteId",
                principalTable: "TiposClientes",
                principalColumn: "TipoClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Descuentos_TiposClientes_TipoClienteId",
                table: "Descuentos",
                column: "TipoClienteId",
                principalTable: "TiposClientes",
                principalColumn: "TipoClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_TiposClientes_TipoClienteId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Descuentos_TiposClientes_TipoClienteId",
                table: "Descuentos");

            migrationBuilder.DropTable(
                name: "TiposClientes");

            migrationBuilder.DropIndex(
                name: "IX_Descuentos_TipoClienteId",
                table: "Descuentos");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_TipoClienteId",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "TipoClienteId",
                table: "Descuentos",
                newName: "TipoCliente");

            migrationBuilder.RenameColumn(
                name: "TipoClienteId",
                table: "Clientes",
                newName: "TipoDeCliente");
        }
    }
}
