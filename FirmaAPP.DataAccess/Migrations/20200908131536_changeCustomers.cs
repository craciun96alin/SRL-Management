using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class changeCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IBAN",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TVAPaying",
                table: "Customers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IBAN",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TVAPaying",
                table: "Customers");

            migrationBuilder.AlterColumn<short>(
                name: "Rating",
                table: "Customers",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
