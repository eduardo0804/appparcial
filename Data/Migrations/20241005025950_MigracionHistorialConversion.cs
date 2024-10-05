using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appparcial.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionHistorialConversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BtcAmount",
                table: "t_historial_conversion");

            migrationBuilder.DropColumn(
                name: "UsdAmount",
                table: "t_historial_conversion");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "t_historial_conversion",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MonedaDestino",
                table: "t_historial_conversion",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonedaOrigen",
                table: "t_historial_conversion",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TasaCambio",
                table: "t_historial_conversion",
                type: "numeric",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "t_historial_conversion");

            migrationBuilder.DropColumn(
                name: "MonedaDestino",
                table: "t_historial_conversion");

            migrationBuilder.DropColumn(
                name: "MonedaOrigen",
                table: "t_historial_conversion");

            migrationBuilder.DropColumn(
                name: "TasaCambio",
                table: "t_historial_conversion");

            migrationBuilder.AddColumn<decimal>(
                name: "BtcAmount",
                table: "t_historial_conversion",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UsdAmount",
                table: "t_historial_conversion",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
