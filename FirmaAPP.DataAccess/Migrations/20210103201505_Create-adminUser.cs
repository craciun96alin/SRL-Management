using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class CreateadminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "FirstName", "LastLogin", "LastName", "Password", "UserRole" },
                values: new object[] { 1, "Admin", null, null, null, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);
        }
    }
}
