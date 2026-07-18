using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class AjustesInventarioVendedorYSingular : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_TiposClientes_TipoClienteId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Descuentos_TiposClientes_TipoClienteId",
                table: "Descuentos");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVenta_Productos_ProductoId",
                table: "DetallesVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesVenta_Ventas_VentaId",
                table: "DetallesVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Ventas_VentaId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_CategoriaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Clientes_ClienteId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Descuentos_DescuentoId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_MetodosPago_MetodoPagoId",
                table: "Ventas");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Sucursales_SucursalId",
                table: "Ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposClientes",
                table: "TiposClientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sucursales",
                table: "Sucursales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MetodosPago",
                table: "MetodosPago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesVenta",
                table: "DetallesVenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Descuentos",
                table: "Descuentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Ventas",
                newName: "Venta");

            migrationBuilder.RenameTable(
                name: "TiposClientes",
                newName: "TipoCliente");

            migrationBuilder.RenameTable(
                name: "Sucursales",
                newName: "Sucursal");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Producto");

            migrationBuilder.RenameTable(
                name: "MetodosPago",
                newName: "MetodoPago");

            migrationBuilder.RenameTable(
                name: "Facturas",
                newName: "Factura");

            migrationBuilder.RenameTable(
                name: "DetallesVenta",
                newName: "DetalleVenta");

            migrationBuilder.RenameTable(
                name: "Descuentos",
                newName: "Descuento");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Categoria");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_SucursalId",
                table: "Venta",
                newName: "IX_Venta_SucursalId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_MetodoPagoId",
                table: "Venta",
                newName: "IX_Venta_MetodoPagoId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_DescuentoId",
                table: "Venta",
                newName: "IX_Venta_DescuentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_ClienteId",
                table: "Venta",
                newName: "IX_Venta_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_CategoriaId",
                table: "Producto",
                newName: "IX_Producto_CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_VentaId",
                table: "Factura",
                newName: "IX_Factura_VentaId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesVenta_ProductoId",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_Descuentos_TipoClienteId",
                table: "Descuento",
                newName: "IX_Descuento_TipoClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_TipoClienteId",
                table: "Cliente",
                newName: "IX_Cliente_TipoClienteId");

            migrationBuilder.AddColumn<decimal>(
                name: "MontoSubtotal",
                table: "Venta",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "VendedorId",
                table: "Venta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Producto",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venta",
                table: "Venta",
                column: "VentaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoCliente",
                table: "TipoCliente",
                column: "TipoClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sucursal",
                table: "Sucursal",
                column: "SucursalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MetodoPago",
                table: "MetodoPago",
                column: "MetodoPagoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factura",
                table: "Factura",
                column: "FacturaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleVenta",
                table: "DetalleVenta",
                columns: new[] { "VentaId", "ProductoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Descuento",
                table: "Descuento",
                column: "DescuentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "CategoriaId");

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    SucursalId = table.Column<int>(type: "int", nullable: false),
                    StockProducto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => new { x.ProductoId, x.SucursalId });
                    table.ForeignKey(
                        name: "FK_Inventario_Producto_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Producto",
                        principalColumn: "ProductoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventario_Sucursal_SucursalId",
                        column: x => x.SucursalId,
                        principalTable: "Sucursal",
                        principalColumn: "SucursalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    VendedorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.VendedorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venta_VendedorId",
                table: "Venta",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_Codigo",
                table: "Producto",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_SucursalId",
                table: "Inventario",
                column: "SucursalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_TipoCliente_TipoClienteId",
                table: "Cliente",
                column: "TipoClienteId",
                principalTable: "TipoCliente",
                principalColumn: "TipoClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Descuento_TipoCliente_TipoClienteId",
                table: "Descuento",
                column: "TipoClienteId",
                principalTable: "TipoCliente",
                principalColumn: "TipoClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_Producto_ProductoId",
                table: "DetalleVenta",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_Venta_VentaId",
                table: "DetalleVenta",
                column: "VentaId",
                principalTable: "Venta",
                principalColumn: "VentaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Venta_VentaId",
                table: "Factura",
                column: "VentaId",
                principalTable: "Venta",
                principalColumn: "VentaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Categoria_CategoriaId",
                table: "Producto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Cliente_ClienteId",
                table: "Venta",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Descuento_DescuentoId",
                table: "Venta",
                column: "DescuentoId",
                principalTable: "Descuento",
                principalColumn: "DescuentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_MetodoPago_MetodoPagoId",
                table: "Venta",
                column: "MetodoPagoId",
                principalTable: "MetodoPago",
                principalColumn: "MetodoPagoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Sucursal_SucursalId",
                table: "Venta",
                column: "SucursalId",
                principalTable: "Sucursal",
                principalColumn: "SucursalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Vendedor_VendedorId",
                table: "Venta",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "VendedorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_TipoCliente_TipoClienteId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Descuento_TipoCliente_TipoClienteId",
                table: "Descuento");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Producto_ProductoId",
                table: "DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Venta_VentaId",
                table: "DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Venta_VentaId",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Categoria_CategoriaId",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Cliente_ClienteId",
                table: "Venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Descuento_DescuentoId",
                table: "Venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_MetodoPago_MetodoPagoId",
                table: "Venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Sucursal_SucursalId",
                table: "Venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Vendedor_VendedorId",
                table: "Venta");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venta",
                table: "Venta");

            migrationBuilder.DropIndex(
                name: "IX_Venta_VendedorId",
                table: "Venta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoCliente",
                table: "TipoCliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sucursal",
                table: "Sucursal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_Codigo",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MetodoPago",
                table: "MetodoPago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factura",
                table: "Factura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleVenta",
                table: "DetalleVenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Descuento",
                table: "Descuento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "MontoSubtotal",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "VendedorId",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Producto");

            migrationBuilder.RenameTable(
                name: "Venta",
                newName: "Ventas");

            migrationBuilder.RenameTable(
                name: "TipoCliente",
                newName: "TiposClientes");

            migrationBuilder.RenameTable(
                name: "Sucursal",
                newName: "Sucursales");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "MetodoPago",
                newName: "MetodosPago");

            migrationBuilder.RenameTable(
                name: "Factura",
                newName: "Facturas");

            migrationBuilder.RenameTable(
                name: "DetalleVenta",
                newName: "DetallesVenta");

            migrationBuilder.RenameTable(
                name: "Descuento",
                newName: "Descuentos");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categorias");

            migrationBuilder.RenameIndex(
                name: "IX_Venta_SucursalId",
                table: "Ventas",
                newName: "IX_Ventas_SucursalId");

            migrationBuilder.RenameIndex(
                name: "IX_Venta_MetodoPagoId",
                table: "Ventas",
                newName: "IX_Ventas_MetodoPagoId");

            migrationBuilder.RenameIndex(
                name: "IX_Venta_DescuentoId",
                table: "Ventas",
                newName: "IX_Ventas_DescuentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Venta_ClienteId",
                table: "Ventas",
                newName: "IX_Ventas_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_CategoriaId",
                table: "Productos",
                newName: "IX_Productos_CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Factura_VentaId",
                table: "Facturas",
                newName: "IX_Facturas_VentaId");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_ProductoId",
                table: "DetallesVenta",
                newName: "IX_DetallesVenta_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_Descuento_TipoClienteId",
                table: "Descuentos",
                newName: "IX_Descuentos_TipoClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Cliente_TipoClienteId",
                table: "Clientes",
                newName: "IX_Clientes_TipoClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas",
                column: "VentaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposClientes",
                table: "TiposClientes",
                column: "TipoClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sucursales",
                table: "Sucursales",
                column: "SucursalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MetodosPago",
                table: "MetodosPago",
                column: "MetodoPagoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas",
                column: "FacturaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesVenta",
                table: "DetallesVenta",
                columns: new[] { "VentaId", "ProductoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Descuentos",
                table: "Descuentos",
                column: "DescuentoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "CategoriaId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVenta_Productos_ProductoId",
                table: "DetallesVenta",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "ProductoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesVenta_Ventas_VentaId",
                table: "DetallesVenta",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "VentaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Ventas_VentaId",
                table: "Facturas",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "VentaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CategoriaId",
                table: "Productos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Clientes_ClienteId",
                table: "Ventas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Descuentos_DescuentoId",
                table: "Ventas",
                column: "DescuentoId",
                principalTable: "Descuentos",
                principalColumn: "DescuentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_MetodosPago_MetodoPagoId",
                table: "Ventas",
                column: "MetodoPagoId",
                principalTable: "MetodosPago",
                principalColumn: "MetodoPagoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Sucursales_SucursalId",
                table: "Ventas",
                column: "SucursalId",
                principalTable: "Sucursales",
                principalColumn: "SucursalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
