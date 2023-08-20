using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopVintage.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class RelacionZapatoTalle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Talles_IdZapato",
                table: "Talles",
                column: "IdZapato");

            migrationBuilder.AddForeignKey(
                name: "FK_Talles_Zapatos_IdZapato",
                table: "Talles",
                column: "IdZapato",
                principalTable: "Zapatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talles_Zapatos_IdZapato",
                table: "Talles");

            migrationBuilder.DropIndex(
                name: "IX_Talles_IdZapato",
                table: "Talles");
        }
    }
}
