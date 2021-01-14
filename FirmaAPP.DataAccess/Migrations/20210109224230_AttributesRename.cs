using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class AttributesRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filaments_AttributeColors_AttributeColorsID",
                table: "Filaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Tshirts_AttributeColors_AttributeColorsID",
                table: "Tshirts");

            migrationBuilder.DropForeignKey(
                name: "FK_Vinyls_AttributeColors_AttributeColorsID",
                table: "Vinyls");

            migrationBuilder.DropTable(
                name: "AttributeColors");

            migrationBuilder.CreateTable(
                name: "AttributeColor",
                columns: table => new
                {
                    AttributeColorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeColor", x => x.AttributeColorID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_AttributeColor_AttributeColorsID",
                table: "Filaments",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_AttributeColor_AttributeColorsID",
                table: "Tshirts",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_AttributeColor_AttributeColorsID",
                table: "Vinyls",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "AttributeColor");

            migrationBuilder.CreateTable(
                name: "AttributeColors",
                columns: table => new
                {
                    AttributeColorsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeColors", x => x.AttributeColorsID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_AttributeColors_AttributeColorsID",
                table: "Filaments",
                column: "AttributeColorsID",
                principalTable: "AttributeColors",
                principalColumn: "AttributeColorsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_AttributeColors_AttributeColorsID",
                table: "Tshirts",
                column: "AttributeColorsID",
                principalTable: "AttributeColors",
                principalColumn: "AttributeColorsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_AttributeColors_AttributeColorsID",
                table: "Vinyls",
                column: "AttributeColorsID",
                principalTable: "AttributeColors",
                principalColumn: "AttributeColorsID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
