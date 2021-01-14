using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class attributesChangeContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filaments_AttributeColor_AttributeColorsID",
                table: "Filaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Tshirts_AttributeColor_AttributeColorsID",
                table: "Tshirts");

            migrationBuilder.DropForeignKey(
                name: "FK_Vinyls_AttributeColor_AttributeColorsID",
                table: "Vinyls");

            migrationBuilder.DropIndex(
                name: "IX_Vinyls_AttributeColorsID",
                table: "Vinyls");

            migrationBuilder.DropIndex(
                name: "IX_Tshirts_AttributeColorsID",
                table: "Tshirts");

            migrationBuilder.DropIndex(
                name: "IX_Filaments_AttributeColorsID",
                table: "Filaments");

            migrationBuilder.AddColumn<int>(
                name: "AttributeColorID",
                table: "Vinyls",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttributeColorID",
                table: "Tshirts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttributeColorID",
                table: "Filaments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vinyls_AttributeColorID",
                table: "Vinyls",
                column: "AttributeColorID");

            migrationBuilder.CreateIndex(
                name: "IX_Tshirts_AttributeColorID",
                table: "Tshirts",
                column: "AttributeColorID");

            migrationBuilder.CreateIndex(
                name: "IX_Filaments_AttributeColorID",
                table: "Filaments",
                column: "AttributeColorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_AttributeColor_AttributeColorID",
                table: "Filaments",
                column: "AttributeColorID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_AttributeColor_AttributeColorID",
                table: "Tshirts",
                column: "AttributeColorID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_AttributeColor_AttributeColorID",
                table: "Vinyls",
                column: "AttributeColorID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filaments_AttributeColor_AttributeColorID",
                table: "Filaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Tshirts_AttributeColor_AttributeColorID",
                table: "Tshirts");

            migrationBuilder.DropForeignKey(
                name: "FK_Vinyls_AttributeColor_AttributeColorID",
                table: "Vinyls");

            migrationBuilder.DropIndex(
                name: "IX_Vinyls_AttributeColorID",
                table: "Vinyls");

            migrationBuilder.DropIndex(
                name: "IX_Tshirts_AttributeColorID",
                table: "Tshirts");

            migrationBuilder.DropIndex(
                name: "IX_Filaments_AttributeColorID",
                table: "Filaments");

            migrationBuilder.DropColumn(
                name: "AttributeColorID",
                table: "Vinyls");

            migrationBuilder.DropColumn(
                name: "AttributeColorID",
                table: "Tshirts");

            migrationBuilder.DropColumn(
                name: "AttributeColorID",
                table: "Filaments");

            migrationBuilder.CreateIndex(
                name: "IX_Vinyls_AttributeColorsID",
                table: "Vinyls",
                column: "AttributeColorsID");

            migrationBuilder.CreateIndex(
                name: "IX_Tshirts_AttributeColorsID",
                table: "Tshirts",
                column: "AttributeColorsID");

            migrationBuilder.CreateIndex(
                name: "IX_Filaments_AttributeColorsID",
                table: "Filaments",
                column: "AttributeColorsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_AttributeColor_AttributeColorsID",
                table: "Filaments",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_AttributeColor_AttributeColorsID",
                table: "Tshirts",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_AttributeColor_AttributeColorsID",
                table: "Vinyls",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
