using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopVintage.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class RelacionStockZapatoTalle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stocks_IdTalle",
                table: "Stocks",
                column: "IdTalle");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_IdZapato",
                table: "Stocks",
                column: "IdZapato");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Talles_IdTalle",
                table: "Stocks",
                column: "IdTalle",
                principalTable: "Talles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Zapatos_IdZapato",
                table: "Stocks",
                column: "IdZapato",
                principalTable: "Zapatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Talles_IdTalle",
                table: "Stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Zapatos_IdZapato",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_IdTalle",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_IdZapato",
                table: "Stocks");
        }
    }
}
