using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class ModifyUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "UserRole",
                value: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "UserRole",
                value: 1);
        }
    }
}
