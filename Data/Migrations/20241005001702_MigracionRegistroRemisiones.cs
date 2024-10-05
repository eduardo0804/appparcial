using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appparcial.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionRegistroRemisiones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaEnvio",
                table: "t_remesas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEnvio",
                table: "t_remesas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
