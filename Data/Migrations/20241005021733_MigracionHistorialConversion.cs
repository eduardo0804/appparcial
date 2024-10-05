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
            migrationBuilder.RenameColumn(
                name: "TipoConversion",
                table: "t_historial_conversion",
                newName: "UsdAmount");

            migrationBuilder.RenameColumn(
                name: "TasaConversion",
                table: "t_historial_conversion",
                newName: "BtcAmount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsdAmount",
                table: "t_historial_conversion",
                newName: "TipoConversion");

            migrationBuilder.RenameColumn(
                name: "BtcAmount",
                table: "t_historial_conversion",
                newName: "TasaConversion");
        }
    }
}
