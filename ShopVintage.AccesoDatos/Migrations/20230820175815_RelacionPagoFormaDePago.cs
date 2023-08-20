using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopVintage.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class RelacionPagoFormaDePago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdFormaDePago",
                table: "Pagos",
                column: "IdFormaDePago");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_FormaDePagos_IdFormaDePago",
                table: "Pagos",
                column: "IdFormaDePago",
                principalTable: "FormaDePagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_FormaDePagos_IdFormaDePago",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_IdFormaDePago",
                table: "Pagos");
        }
    }
}
