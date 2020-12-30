using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class addBusinessDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessDetails",
                columns: table => new
                {
                    BusinessDetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CUI = table.Column<string>(nullable: true),
                    IBAN = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    NrReg = table.Column<string>(nullable: true),
                    TVAPaying = table.Column<bool>(nullable: false),
                    DigitalMoney = table.Column<float>(nullable: false),
                    CashMoney = table.Column<float>(nullable: false),
                    ExtraMoney = table.Column<float>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessDetails", x => x.BusinessDetailsID);
                    table.ForeignKey(
                        name: "FK_BusinessDetails_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessDetails_UserID",
                table: "BusinessDetails",
                column: "UserID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessDetails");
        }
    }
}
