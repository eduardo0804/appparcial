using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace appparcial.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionRegistroRemisiones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_remesas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomRemitente = table.Column<string>(type: "text", nullable: true),
                    NomDestinatario = table.Column<string>(type: "text", nullable: true),
                    PaisOrigen = table.Column<string>(type: "text", nullable: true),
                    PaisDestino = table.Column<string>(type: "text", nullable: true),
                    MontoEnviado = table.Column<decimal>(type: "numeric", nullable: false),
                    TasaCambio = table.Column<decimal>(type: "numeric", nullable: false),
                    MontoFinal = table.Column<decimal>(type: "numeric", nullable: false),
                    EstadoTransaccion = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_remesas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_remesas");
        }
    }
}
