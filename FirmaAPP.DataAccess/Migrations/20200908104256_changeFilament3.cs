using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class changeFilament3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tip",
                table: "Filaments",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Stoc",
                table: "Filaments",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "Nume",
                table: "Filaments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Descriere",
                table: "Filaments",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Culoare",
                table: "Filaments",
                newName: "Color");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Filaments",
                newName: "Tip");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Filaments",
                newName: "Stoc");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Filaments",
                newName: "Nume");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Filaments",
                newName: "Descriere");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Filaments",
                newName: "Culoare");
        }
    }
}
