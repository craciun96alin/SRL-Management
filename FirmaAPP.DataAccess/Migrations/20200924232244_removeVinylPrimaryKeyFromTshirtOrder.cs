using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class removeVinylPrimaryKeyFromTshirtOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TshirtOrders",
                table: "TshirtOrders");

            migrationBuilder.AlterColumn<int>(
                name: "VinylID",
                table: "TshirtOrders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TshirtOrders",
                table: "TshirtOrders",
                columns: new[] { "TshirtOrderID", "OrderID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TshirtOrders",
                table: "TshirtOrders");

            migrationBuilder.AlterColumn<int>(
                name: "VinylID",
                table: "TshirtOrders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TshirtOrders",
                table: "TshirtOrders",
                columns: new[] { "TshirtOrderID", "OrderID", "VinylID" });
        }
    }
}
