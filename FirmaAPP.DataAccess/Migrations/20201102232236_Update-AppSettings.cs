using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class UpdateAppSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "_3DPrints");

            migrationBuilder.DropColumn(
                name: "HoursWork",
                table: "_3DDesigns");

            migrationBuilder.DropColumn(
                name: "StartingDate",
                table: "_3DDesigns");

            migrationBuilder.AddColumn<string>(
                name: "_3DDesignFolder",
                table: "AppSettings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "_3DPrintFolder",
                table: "AppSettings",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "_3DPrints",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "_3DPrints",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DesignStatus",
                table: "_3DDesigns",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "_3DDesigns",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "HoursOfWork",
                table: "_3DDesigns",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "_3DDesigns",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_3DDesignFolder",
                table: "AppSettings");

            migrationBuilder.DropColumn(
                name: "_3DPrintFolder",
                table: "AppSettings");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "_3DPrints");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "_3DDesigns");

            migrationBuilder.DropColumn(
                name: "HoursOfWork",
                table: "_3DDesigns");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "_3DDesigns");

            migrationBuilder.AlterColumn<short>(
                name: "Rating",
                table: "_3DPrints",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "_3DPrints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "DesignStatus",
                table: "_3DDesigns",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "HoursWork",
                table: "_3DDesigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartingDate",
                table: "_3DDesigns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
