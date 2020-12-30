using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class tryAddIdentityPart1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropColumn(
                name: "TshirtOrderID",
                table: "TshirtOrders");

            migrationBuilder.DropColumn(
                name: "OtherPurchaseOrderID",
                table: "OtherPurchaseOrders");

            migrationBuilder.DropColumn(
                name: "FilamentOrderID",
                table: "FilamentOrders");

            migrationBuilder.DropColumn(
                name: "_3DPrintOrderID",
                table: "_3DPrintOrders");

            migrationBuilder.DropColumn(
                name: "_3DDesignOrderID",
                table: "_3DDesignOrders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TshirtOrderID",
                table: "TshirtOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OtherPurchaseOrderID",
                table: "OtherPurchaseOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FilamentOrderID",
                table: "FilamentOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "_3DPrintOrderID",
                table: "_3DPrintOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "_3DDesignOrderID",
                table: "_3DDesignOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillID = table.Column<int>(type: "int", nullable: false),
                    BillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillStatus = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillID);
                    table.ForeignKey(
                        name: "FK_Bills_Orders_BillID",
                        column: x => x.BillID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
