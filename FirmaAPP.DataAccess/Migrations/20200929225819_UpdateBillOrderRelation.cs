using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class UpdateBillOrderRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Bills_BillID",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Bills_BillID",
                table: "Orders",
                column: "BillID",
                principalTable: "Bills",
                principalColumn: "BillID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Bills_BillID",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Bills_BillID",
                table: "Orders",
                column: "BillID",
                principalTable: "Bills",
                principalColumn: "BillID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
