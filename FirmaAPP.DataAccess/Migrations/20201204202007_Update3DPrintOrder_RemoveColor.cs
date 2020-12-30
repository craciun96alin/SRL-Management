using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class Update3DPrintOrder_RemoveColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "_3DPrintOrders");

            migrationBuilder.AlterColumn<int>(
                name: "Quality",
                table: "_3DPrintOrders",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "Infill",
                table: "_3DPrintOrders",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "Quality",
                table: "_3DPrintOrders",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<short>(
                name: "Infill",
                table: "_3DPrintOrders",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<short>(
                name: "Color",
                table: "_3DPrintOrders",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
