using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class tryAddIdentityPart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TshirtOrders",
                table: "TshirtOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OtherPurchaseOrders",
                table: "OtherPurchaseOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilamentOrders",
                table: "FilamentOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK__3DPrintOrders",
                table: "_3DPrintOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK__3DDesignOrders",
                table: "_3DDesignOrders");

            migrationBuilder.AddColumn<int>(
                name: "TshirtOrderID",
                table: "TshirtOrders",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "OtherPurchaseOrderID",
                table: "OtherPurchaseOrders",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "FilamentOrderID",
                table: "FilamentOrders",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "_3DPrintOrderID",
                table: "_3DPrintOrders",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "_3DDesignOrderID",
                table: "_3DDesignOrders",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TshirtOrders",
                table: "TshirtOrders",
                columns: new[] { "TshirtOrderID", "OrderID", "VinylID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OtherPurchaseOrders",
                table: "OtherPurchaseOrders",
                columns: new[] { "OtherPurchaseOrderID", "OrderID", "OtherPurchaseID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilamentOrders",
                table: "FilamentOrders",
                columns: new[] { "FilamentOrderID", "OrderID", "FilamentID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__3DPrintOrders",
                table: "_3DPrintOrders",
                columns: new[] { "_3DPrintOrderID", "OrderID", "_3DPrintID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__3DDesignOrders",
                table: "_3DDesignOrders",
                columns: new[] { "_3DDesignOrderID", "OrderID", "_3DDesignID" });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillName = table.Column<string>(nullable: true),
                    BillStatus = table.Column<short>(nullable: false),
                    File = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TshirtOrders_OrderID",
                table: "TshirtOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OtherPurchaseOrders_OrderID",
                table: "OtherPurchaseOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillID",
                table: "Orders",
                column: "BillID",
                unique: true,
                filter: "[BillID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FilamentOrders_OrderID",
                table: "FilamentOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX__3DPrintOrders_OrderID",
                table: "_3DPrintOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX__3DDesignOrders_OrderID",
                table: "_3DDesignOrders",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Bills_BillID",
                table: "Orders",
                column: "BillID",
                principalTable: "Bills",
                principalColumn: "BillID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Bills_BillID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TshirtOrders",
                table: "TshirtOrders");

            migrationBuilder.DropIndex(
                name: "IX_TshirtOrders_OrderID",
                table: "TshirtOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OtherPurchaseOrders",
                table: "OtherPurchaseOrders");

            migrationBuilder.DropIndex(
                name: "IX_OtherPurchaseOrders_OrderID",
                table: "OtherPurchaseOrders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_BillID",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilamentOrders",
                table: "FilamentOrders");

            migrationBuilder.DropIndex(
                name: "IX_FilamentOrders_OrderID",
                table: "FilamentOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK__3DPrintOrders",
                table: "_3DPrintOrders");

            migrationBuilder.DropIndex(
                name: "IX__3DPrintOrders_OrderID",
                table: "_3DPrintOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK__3DDesignOrders",
                table: "_3DDesignOrders");

            migrationBuilder.DropIndex(
                name: "IX__3DDesignOrders_OrderID",
                table: "_3DDesignOrders");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_TshirtOrders",
                table: "TshirtOrders",
                columns: new[] { "OrderID", "VinylID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OtherPurchaseOrders",
                table: "OtherPurchaseOrders",
                columns: new[] { "OrderID", "OtherPurchaseID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilamentOrders",
                table: "FilamentOrders",
                columns: new[] { "OrderID", "FilamentID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__3DPrintOrders",
                table: "_3DPrintOrders",
                columns: new[] { "OrderID", "_3DPrintID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__3DDesignOrders",
                table: "_3DDesignOrders",
                columns: new[] { "OrderID", "_3DDesignID" });
        }
    }
}
