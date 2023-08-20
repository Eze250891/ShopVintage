using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopVintage.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class RelacionMarcaZapato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Zapatos_IdMarca",
                table: "Zapatos",
                column: "IdMarca");

            migrationBuilder.AddForeignKey(
                name: "FK_Zapatos_Marcas_IdMarca",
                table: "Zapatos",
                column: "IdMarca",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zapatos_Marcas_IdMarca",
                table: "Zapatos");

            migrationBuilder.DropIndex(
                name: "IX_Zapatos_IdMarca",
                table: "Zapatos");
        }
    }
}
