using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class AddCuentaCorrienteClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaSaldada",
                table: "Venta",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Saldada",
                table: "Venta",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "EsCuentaCorriente",
                table: "MetodoPago",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EsCuentacorrentista",
                table: "Cliente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.Sql(
                @"
                UPDATE [Venta]
                SET [FechaSaldada] = [FechaVenta]
                WHERE [Saldada] = 1;

                IF EXISTS (
                    SELECT 1
                    FROM [MetodoPago]
                    WHERE LOWER(LTRIM(RTRIM([Nombre]))) = N'cuenta corriente'
                )
                BEGIN
                    UPDATE [MetodoPago]
                    SET [Nombre] = N'Cuenta corriente',
                        [Descripcion] = N'Compras financiadas mediante cuenta corriente',
                        [Activo] = 1,
                        [EsCuentaCorriente] = 1
                    WHERE [MetodoPagoId] = (
                        SELECT TOP (1) [MetodoPagoId]
                        FROM [MetodoPago]
                        WHERE LOWER(LTRIM(RTRIM([Nombre]))) = N'cuenta corriente'
                        ORDER BY [MetodoPagoId]
                    );
                END
                ELSE
                BEGIN
                    INSERT INTO [MetodoPago]
                        ([Nombre], [Descripcion], [Activo], [EsCuentaCorriente])
                    VALUES
                        (N'Cuenta corriente',
                         N'Compras financiadas mediante cuenta corriente',
                         1,
                         1);
                END
                "
            );

            migrationBuilder.CreateIndex(
                name: "IX_MetodoPago_EsCuentaCorriente",
                table: "MetodoPago",
                column: "EsCuentaCorriente",
                unique: true,
                filter: "[EsCuentaCorriente] = 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MetodoPago_EsCuentaCorriente",
                table: "MetodoPago");

            migrationBuilder.DropColumn(
                name: "FechaSaldada",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "Saldada",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "EsCuentaCorriente",
                table: "MetodoPago");

            migrationBuilder.DropColumn(
                name: "EsCuentacorrentista",
                table: "Cliente");
        }
    }
}
