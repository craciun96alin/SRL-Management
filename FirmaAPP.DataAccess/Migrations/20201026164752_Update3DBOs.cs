using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class Update3DBOs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstimatedDesignTime",
                table: "_3DDesigns");

            migrationBuilder.DropColumn(
                name: "RealDesignTime",
                table: "_3DDesigns");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeadLineDate",
                table: "_3DDesigns",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "_3DDesigns",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "_3DDesigns",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "_3DDesigns",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeadLineDate",
                table: "_3DDesigns");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "_3DDesigns");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "_3DDesigns");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "_3DDesigns");

            migrationBuilder.AddColumn<int>(
                name: "EstimatedDesignTime",
                table: "_3DDesigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RealDesignTime",
                table: "_3DDesigns",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
