using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class Update3DDesign_RemoveDesignToRecreateWithoutFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__3DDesignOrders__3DDesigns__3DDesignID",
                table: "_3DDesignOrders");

            migrationBuilder.DropForeignKey(
                name: "FK__3DDesigns__3DPrints__3DDesignID",
                table: "_3DDesigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK__3DDesigns",
                table: "_3DDesigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK__3DDesignOrders",
                table: "_3DDesignOrders");

            migrationBuilder.DropIndex(
                name: "IX__3DDesignOrders__3DDesignID",
                table: "_3DDesignOrders");

            migrationBuilder.DropColumn(
                name: "_3DDesignID",
                table: "_3DDesigns");

            migrationBuilder.DropColumn(
                name: "_3DPrintID",
                table: "_3DDesigns");

            migrationBuilder.DropColumn(
                name: "_3DDesignID",
                table: "_3DDesignOrders");

            migrationBuilder.AddPrimaryKey(
                name: "PK__3DDesignOrders",
                table: "_3DDesignOrders",
                column: "_3DDesignOrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__3DDesignOrders",
                table: "_3DDesignOrders");

            migrationBuilder.AddColumn<int>(
                name: "_3DDesignID",
                table: "_3DDesigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "_3DPrintID",
                table: "_3DDesigns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_3DDesignID",
                table: "_3DDesignOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK__3DDesigns",
                table: "_3DDesigns",
                column: "_3DDesignID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__3DDesignOrders",
                table: "_3DDesignOrders",
                columns: new[] { "_3DDesignOrderID", "OrderID", "_3DDesignID" });

            migrationBuilder.CreateIndex(
                name: "IX__3DDesignOrders__3DDesignID",
                table: "_3DDesignOrders",
                column: "_3DDesignID");

            migrationBuilder.AddForeignKey(
                name: "FK__3DDesignOrders__3DDesigns__3DDesignID",
                table: "_3DDesignOrders",
                column: "_3DDesignID",
                principalTable: "_3DDesigns",
                principalColumn: "_3DDesignID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3DDesigns__3DPrints__3DDesignID",
                table: "_3DDesigns",
                column: "_3DDesignID",
                principalTable: "_3DPrints",
                principalColumn: "_3DPrintID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
