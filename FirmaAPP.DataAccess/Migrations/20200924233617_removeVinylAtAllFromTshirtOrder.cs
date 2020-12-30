using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class removeVinylAtAllFromTshirtOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VinylID",
                table: "TshirtOrders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VinylID",
                table: "TshirtOrders",
                type: "int",
                nullable: true);
        }
    }
}
