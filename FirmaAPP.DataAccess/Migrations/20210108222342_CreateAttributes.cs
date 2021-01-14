using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class CreateAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Vinyls");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Vinyls");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Tshirts");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Tshirts");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Filaments");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Filaments");

            migrationBuilder.DropColumn(
                name: "Quality",
                table: "_3DPrintOrders");

            migrationBuilder.AddColumn<int>(
                name: "AttributeColorsID",
                table: "Vinyls",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttributeVinylsTypeID",
                table: "Vinyls",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttributeColorsID",
                table: "Tshirts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttributeTshirtsTypeID",
                table: "Tshirts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttributeColorsID",
                table: "Filaments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttributeFilamentsTypeID",
                table: "Filaments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Attribute3DPrintsQualityID",
                table: "_3DPrintOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Attribute3DPrintsQuality",
                columns: table => new
                {
                    Attribute3DPrintsQualityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attribute3DPrintsQuality", x => x.Attribute3DPrintsQualityID);
                });

            migrationBuilder.CreateTable(
                name: "AttributeColors",
                columns: table => new
                {
                    AttributeColorsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeColors", x => x.AttributeColorsID);
                });

            migrationBuilder.CreateTable(
                name: "AttributeFilamentsType",
                columns: table => new
                {
                    AttributeFilamentsTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeFilamentsType", x => x.AttributeFilamentsTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AttributeTshirtsType",
                columns: table => new
                {
                    AttributeTshirtsTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeTshirtsType", x => x.AttributeTshirtsTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AttributeVinylsType",
                columns: table => new
                {
                    AttributeVinylsTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeVinylsType", x => x.AttributeVinylsTypeID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vinyls_AttributeColorsID",
                table: "Vinyls",
                column: "AttributeColorsID");

            migrationBuilder.CreateIndex(
                name: "IX_Vinyls_AttributeVinylsTypeID",
                table: "Vinyls",
                column: "AttributeVinylsTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tshirts_AttributeColorsID",
                table: "Tshirts",
                column: "AttributeColorsID");

            migrationBuilder.CreateIndex(
                name: "IX_Tshirts_AttributeTshirtsTypeID",
                table: "Tshirts",
                column: "AttributeTshirtsTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Filaments_AttributeColorsID",
                table: "Filaments",
                column: "AttributeColorsID");

            migrationBuilder.CreateIndex(
                name: "IX_Filaments_AttributeFilamentsTypeID",
                table: "Filaments",
                column: "AttributeFilamentsTypeID");

            migrationBuilder.CreateIndex(
                name: "IX__3DPrintOrders_Attribute3DPrintsQualityID",
                table: "_3DPrintOrders",
                column: "Attribute3DPrintsQualityID");

            migrationBuilder.AddForeignKey(
                name: "FK__3DPrintOrders_Attribute3DPrintsQuality_Attribute3DPrintsQualityID",
                table: "_3DPrintOrders",
                column: "Attribute3DPrintsQualityID",
                principalTable: "Attribute3DPrintsQuality",
                principalColumn: "Attribute3DPrintsQualityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_AttributeColors_AttributeColorsID",
                table: "Filaments",
                column: "AttributeColorsID",
                principalTable: "AttributeColors",
                principalColumn: "AttributeColorsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_AttributeFilamentsType_AttributeFilamentsTypeID",
                table: "Filaments",
                column: "AttributeFilamentsTypeID",
                principalTable: "AttributeFilamentsType",
                principalColumn: "AttributeFilamentsTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_AttributeColors_AttributeColorsID",
                table: "Tshirts",
                column: "AttributeColorsID",
                principalTable: "AttributeColors",
                principalColumn: "AttributeColorsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_AttributeTshirtsType_AttributeTshirtsTypeID",
                table: "Tshirts",
                column: "AttributeTshirtsTypeID",
                principalTable: "AttributeTshirtsType",
                principalColumn: "AttributeTshirtsTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_AttributeColors_AttributeColorsID",
                table: "Vinyls",
                column: "AttributeColorsID",
                principalTable: "AttributeColors",
                principalColumn: "AttributeColorsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_AttributeVinylsType_AttributeVinylsTypeID",
                table: "Vinyls",
                column: "AttributeVinylsTypeID",
                principalTable: "AttributeVinylsType",
                principalColumn: "AttributeVinylsTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__3DPrintOrders_Attribute3DPrintsQuality_Attribute3DPrintsQualityID",
                table: "_3DPrintOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Filaments_AttributeColors_AttributeColorsID",
                table: "Filaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Filaments_AttributeFilamentsType_AttributeFilamentsTypeID",
                table: "Filaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Tshirts_AttributeColors_AttributeColorsID",
                table: "Tshirts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tshirts_AttributeTshirtsType_AttributeTshirtsTypeID",
                table: "Tshirts");

            migrationBuilder.DropForeignKey(
                name: "FK_Vinyls_AttributeColors_AttributeColorsID",
                table: "Vinyls");

            migrationBuilder.DropForeignKey(
                name: "FK_Vinyls_AttributeVinylsType_AttributeVinylsTypeID",
                table: "Vinyls");

            migrationBuilder.DropTable(
                name: "Attribute3DPrintsQuality");

            migrationBuilder.DropTable(
                name: "AttributeColors");

            migrationBuilder.DropTable(
                name: "AttributeFilamentsType");

            migrationBuilder.DropTable(
                name: "AttributeTshirtsType");

            migrationBuilder.DropTable(
                name: "AttributeVinylsType");

            migrationBuilder.DropIndex(
                name: "IX_Vinyls_AttributeColorsID",
                table: "Vinyls");

            migrationBuilder.DropIndex(
                name: "IX_Vinyls_AttributeVinylsTypeID",
                table: "Vinyls");

            migrationBuilder.DropIndex(
                name: "IX_Tshirts_AttributeColorsID",
                table: "Tshirts");

            migrationBuilder.DropIndex(
                name: "IX_Tshirts_AttributeTshirtsTypeID",
                table: "Tshirts");

            migrationBuilder.DropIndex(
                name: "IX_Filaments_AttributeColorsID",
                table: "Filaments");

            migrationBuilder.DropIndex(
                name: "IX_Filaments_AttributeFilamentsTypeID",
                table: "Filaments");

            migrationBuilder.DropIndex(
                name: "IX__3DPrintOrders_Attribute3DPrintsQualityID",
                table: "_3DPrintOrders");

            migrationBuilder.DropColumn(
                name: "AttributeColorsID",
                table: "Vinyls");

            migrationBuilder.DropColumn(
                name: "AttributeVinylsTypeID",
                table: "Vinyls");

            migrationBuilder.DropColumn(
                name: "AttributeColorsID",
                table: "Tshirts");

            migrationBuilder.DropColumn(
                name: "AttributeTshirtsTypeID",
                table: "Tshirts");

            migrationBuilder.DropColumn(
                name: "AttributeColorsID",
                table: "Filaments");

            migrationBuilder.DropColumn(
                name: "AttributeFilamentsTypeID",
                table: "Filaments");

            migrationBuilder.DropColumn(
                name: "Attribute3DPrintsQualityID",
                table: "_3DPrintOrders");

            migrationBuilder.AddColumn<int>(
                name: "Color",
                table: "Vinyls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Vinyls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Color",
                table: "Tshirts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Tshirts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Color",
                table: "Filaments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Filaments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quality",
                table: "_3DPrintOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
