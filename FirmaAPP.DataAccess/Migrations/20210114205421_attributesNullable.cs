using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class attributesNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__3DPrintOrders_Attribute3DPrintsQuality_Attribute3DPrintsQualityID",
                table: "_3DPrintOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Filaments_AttributeColor_AttributeColorsID",
                table: "Filaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Filaments_AttributeFilamentsType_AttributeFilamentsTypeID",
                table: "Filaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Tshirts_AttributeColor_AttributeColorsID",
                table: "Tshirts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tshirts_AttributeTshirtsType_AttributeTshirtsTypeID",
                table: "Tshirts");

            migrationBuilder.DropForeignKey(
                name: "FK_Vinyls_AttributeColor_AttributeColorsID",
                table: "Vinyls");

            migrationBuilder.DropForeignKey(
                name: "FK_Vinyls_AttributeVinylsType_AttributeVinylsTypeID",
                table: "Vinyls");

            migrationBuilder.AlterColumn<int>(
                name: "AttributeVinylsTypeID",
                table: "Vinyls",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AttributeColorsID",
                table: "Vinyls",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AttributeTshirtsTypeID",
                table: "Tshirts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AttributeColorsID",
                table: "Tshirts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AttributeFilamentsTypeID",
                table: "Filaments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AttributeColorsID",
                table: "Filaments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Attribute3DPrintsQualityID",
                table: "_3DPrintOrders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK__3DPrintOrders_Attribute3DPrintsQuality_Attribute3DPrintsQualityID",
                table: "_3DPrintOrders",
                column: "Attribute3DPrintsQualityID",
                principalTable: "Attribute3DPrintsQuality",
                principalColumn: "Attribute3DPrintsQualityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_AttributeColor_AttributeColorsID",
                table: "Filaments",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_AttributeFilamentsType_AttributeFilamentsTypeID",
                table: "Filaments",
                column: "AttributeFilamentsTypeID",
                principalTable: "AttributeFilamentsType",
                principalColumn: "AttributeFilamentsTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_AttributeColor_AttributeColorsID",
                table: "Tshirts",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_AttributeTshirtsType_AttributeTshirtsTypeID",
                table: "Tshirts",
                column: "AttributeTshirtsTypeID",
                principalTable: "AttributeTshirtsType",
                principalColumn: "AttributeTshirtsTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_AttributeColor_AttributeColorsID",
                table: "Vinyls",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_AttributeVinylsType_AttributeVinylsTypeID",
                table: "Vinyls",
                column: "AttributeVinylsTypeID",
                principalTable: "AttributeVinylsType",
                principalColumn: "AttributeVinylsTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__3DPrintOrders_Attribute3DPrintsQuality_Attribute3DPrintsQualityID",
                table: "_3DPrintOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Filaments_AttributeColor_AttributeColorsID",
                table: "Filaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Filaments_AttributeFilamentsType_AttributeFilamentsTypeID",
                table: "Filaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Tshirts_AttributeColor_AttributeColorsID",
                table: "Tshirts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tshirts_AttributeTshirtsType_AttributeTshirtsTypeID",
                table: "Tshirts");

            migrationBuilder.DropForeignKey(
                name: "FK_Vinyls_AttributeColor_AttributeColorsID",
                table: "Vinyls");

            migrationBuilder.DropForeignKey(
                name: "FK_Vinyls_AttributeVinylsType_AttributeVinylsTypeID",
                table: "Vinyls");

            migrationBuilder.AlterColumn<int>(
                name: "AttributeVinylsTypeID",
                table: "Vinyls",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AttributeColorsID",
                table: "Vinyls",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AttributeTshirtsTypeID",
                table: "Tshirts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AttributeColorsID",
                table: "Tshirts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AttributeFilamentsTypeID",
                table: "Filaments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AttributeColorsID",
                table: "Filaments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Attribute3DPrintsQualityID",
                table: "_3DPrintOrders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK__3DPrintOrders_Attribute3DPrintsQuality_Attribute3DPrintsQualityID",
                table: "_3DPrintOrders",
                column: "Attribute3DPrintsQualityID",
                principalTable: "Attribute3DPrintsQuality",
                principalColumn: "Attribute3DPrintsQualityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_AttributeColor_AttributeColorsID",
                table: "Filaments",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filaments_AttributeFilamentsType_AttributeFilamentsTypeID",
                table: "Filaments",
                column: "AttributeFilamentsTypeID",
                principalTable: "AttributeFilamentsType",
                principalColumn: "AttributeFilamentsTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_AttributeColor_AttributeColorsID",
                table: "Tshirts",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tshirts_AttributeTshirtsType_AttributeTshirtsTypeID",
                table: "Tshirts",
                column: "AttributeTshirtsTypeID",
                principalTable: "AttributeTshirtsType",
                principalColumn: "AttributeTshirtsTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_AttributeColor_AttributeColorsID",
                table: "Vinyls",
                column: "AttributeColorsID",
                principalTable: "AttributeColor",
                principalColumn: "AttributeColorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyls_AttributeVinylsType_AttributeVinylsTypeID",
                table: "Vinyls",
                column: "AttributeVinylsTypeID",
                principalTable: "AttributeVinylsType",
                principalColumn: "AttributeVinylsTypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
