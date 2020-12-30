using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class tryAddIdentityToOrderVinyl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VinylOrders",
                table: "VinylOrders");

            migrationBuilder.AddColumn<int>(
                name: "VinylOrderID",
                table: "VinylOrders",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VinylOrders",
                table: "VinylOrders",
                columns: new[] { "VinylOrderID", "OrderID", "VinylID" });

            migrationBuilder.CreateIndex(
                name: "IX_VinylOrders_OrderID",
                table: "VinylOrders",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VinylOrders",
                table: "VinylOrders");

            migrationBuilder.DropIndex(
                name: "IX_VinylOrders_OrderID",
                table: "VinylOrders");

            migrationBuilder.DropColumn(
                name: "VinylOrderID",
                table: "VinylOrders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VinylOrders",
                table: "VinylOrders",
                columns: new[] { "OrderID", "VinylID" });
        }
    }
}
