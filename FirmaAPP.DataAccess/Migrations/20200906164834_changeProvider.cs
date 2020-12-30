using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class changeProvider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Providers");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Providers",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Providers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IBAN",
                table: "Providers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Providers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TVAPaying",
                table: "Providers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "IBAN",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "TVAPaying",
                table: "Providers");

            migrationBuilder.AlterColumn<short>(
                name: "Rating",
                table: "Providers",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
