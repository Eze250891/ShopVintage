using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopVintage.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class RelacionPagoZapatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdPrecioZapato",
                table: "Pagos",
                column: "IdPrecioZapato");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Zapatos_IdPrecioZapato",
                table: "Pagos",
                column: "IdPrecioZapato",
                principalTable: "Zapatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Zapatos_IdPrecioZapato",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_IdPrecioZapato",
                table: "Pagos");
        }
    }
}
