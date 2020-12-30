using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class MakeBillIdNotUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_BillID",
                table: "Orders");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillID",
                table: "Orders",
                column: "BillID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Orders_BillID",
                table: "Orders");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillID",
                table: "Orders",
                column: "BillID",
                unique: true,
                filter: "[BillID] IS NOT NULL");
        }
    }
}
