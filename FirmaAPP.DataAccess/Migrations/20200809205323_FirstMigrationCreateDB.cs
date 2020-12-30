using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirmaAPP.DataAccess.Migrations
{
    public partial class FirstMigrationCreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_3DPrints",
                columns: table => new
                {
                    _3DPrintID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _3DDesignID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    FileGCode = table.Column<byte[]>(nullable: true),
                    Rating = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3DPrints", x => x._3DPrintID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CUI = table.Column<string>(nullable: true),
                    Rating = table.Column<short>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    ProviderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    CUI = table.Column<string>(nullable: true),
                    Rating = table.Column<short>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.ProviderID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserRole = table.Column<int>(nullable: false),
                    LastLogin = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "_3DDesigns",
                columns: table => new
                {
                    _3DDesignID = table.Column<int>(nullable: false),
                    _3DPrintID = table.Column<int>(nullable: true),
                    DesignStatus = table.Column<short>(nullable: false),
                    EstimatedDesignTime = table.Column<int>(nullable: false),
                    RealDesignTime = table.Column<int>(nullable: false),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    FinalizeDate = table.Column<DateTime>(nullable: true),
                    HoursWork = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3DDesigns", x => x._3DDesignID);
                    table.ForeignKey(
                        name: "FK__3DDesigns__3DPrints__3DDesignID",
                        column: x => x._3DDesignID,
                        principalTable: "_3DPrints",
                        principalColumn: "_3DPrintID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Filaments",
                columns: table => new
                {
                    FilamentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderID = table.Column<int>(nullable: true),
                    Type = table.Column<short>(nullable: false),
                    Color = table.Column<short>(nullable: false),
                    Stock = table.Column<float>(nullable: false),
                    Rating = table.Column<short>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filaments", x => x.FilamentID);
                    table.ForeignKey(
                        name: "FK_Filaments_Providers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "Providers",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OtherPurchases",
                columns: table => new
                {
                    OtherPurchaseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Stock = table.Column<float>(nullable: true),
                    Rating = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherPurchases", x => x.OtherPurchaseID);
                    table.ForeignKey(
                        name: "FK_OtherPurchases_Providers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "Providers",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tshirts",
                columns: table => new
                {
                    TshirtID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderID = table.Column<int>(nullable: true),
                    Color = table.Column<short>(nullable: false),
                    Sex = table.Column<byte>(nullable: false),
                    Size = table.Column<short>(nullable: false),
                    Type = table.Column<short>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Rating = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tshirts", x => x.TshirtID);
                    table.ForeignKey(
                        name: "FK_Tshirts_Providers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "Providers",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vinyls",
                columns: table => new
                {
                    VinylID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderID = table.Column<int>(nullable: true),
                    Type = table.Column<short>(nullable: false),
                    Color = table.Column<short>(nullable: false),
                    Stock = table.Column<float>(nullable: false),
                    Rating = table.Column<short>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vinyls", x => x.VinylID);
                    table.ForeignKey(
                        name: "FK_Vinyls_Providers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "Providers",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderType = table.Column<short>(nullable: false),
                    CustomerID = table.Column<int>(nullable: true),
                    ProviderID = table.Column<int>(nullable: true),
                    BillID = table.Column<int>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    DeadLineDate = table.Column<DateTime>(nullable: true),
                    FinalizeDate = table.Column<DateTime>(nullable: true),
                    OrderStatus = table.Column<short>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    ShippingPrice = table.Column<float>(nullable: false),
                    TotalPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Providers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "Providers",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3DDesignOrders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    _3DDesignID = table.Column<int>(nullable: false),
                    _3DDesignOrderID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3DDesignOrders", x => new { x.OrderID, x._3DDesignID });
                    table.ForeignKey(
                        name: "FK__3DDesignOrders_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__3DDesignOrders__3DDesigns__3DDesignID",
                        column: x => x._3DDesignID,
                        principalTable: "_3DDesigns",
                        principalColumn: "_3DDesignID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3DPrintOrders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    _3DPrintID = table.Column<int>(nullable: false),
                    _3DPrintOrderID = table.Column<int>(nullable: false),
                    FilamentID = table.Column<int>(nullable: true),
                    Color = table.Column<short>(nullable: false),
                    Infill = table.Column<short>(nullable: false),
                    Quality = table.Column<short>(nullable: false),
                    Wheight = table.Column<float>(nullable: false),
                    PrintingTimeInMin = table.Column<int>(nullable: false),
                    PrintsQuantity = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3DPrintOrders", x => new { x.OrderID, x._3DPrintID });
                    table.ForeignKey(
                        name: "FK__3DPrintOrders_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__3DPrintOrders__3DPrints__3DPrintID",
                        column: x => x._3DPrintID,
                        principalTable: "_3DPrints",
                        principalColumn: "_3DPrintID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillID = table.Column<int>(nullable: false),
                    BillName = table.Column<string>(nullable: true),
                    BillStatus = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillID);
                    table.ForeignKey(
                        name: "FK_Bills_Orders_BillID",
                        column: x => x.BillID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilamentOrders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    FilamentID = table.Column<int>(nullable: false),
                    FilamentOrderID = table.Column<int>(nullable: false),
                    Quantity = table.Column<float>(nullable: false),
                    TotalPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilamentOrders", x => new { x.OrderID, x.FilamentID });
                    table.ForeignKey(
                        name: "FK_FilamentOrders_Filaments_FilamentID",
                        column: x => x.FilamentID,
                        principalTable: "Filaments",
                        principalColumn: "FilamentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilamentOrders_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherPurchaseOrders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    OtherPurchaseID = table.Column<int>(nullable: false),
                    OtherPurchaseOrderID = table.Column<int>(nullable: false),
                    Quantity = table.Column<float>(nullable: false),
                    TotalPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherPurchaseOrders", x => new { x.OrderID, x.OtherPurchaseID });
                    table.ForeignKey(
                        name: "FK_OtherPurchaseOrders_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OtherPurchaseOrders_OtherPurchases_OtherPurchaseID",
                        column: x => x.OtherPurchaseID,
                        principalTable: "OtherPurchases",
                        principalColumn: "OtherPurchaseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TshirtOrders",
                columns: table => new
                {
                    VinylID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false),
                    TshirtOrderID = table.Column<int>(nullable: false),
                    TshirtID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    PrintingType = table.Column<short>(nullable: false),
                    TotalPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TshirtOrders", x => new { x.OrderID, x.VinylID });
                    table.ForeignKey(
                        name: "FK_TshirtOrders_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TshirtOrders_Tshirts_TshirtID",
                        column: x => x.TshirtID,
                        principalTable: "Tshirts",
                        principalColumn: "TshirtID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VinylOrders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    VinylID = table.Column<int>(nullable: false),
                    VinylOrderID = table.Column<int>(nullable: false),
                    Quantity = table.Column<float>(nullable: false),
                    TotalPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VinylOrders", x => new { x.OrderID, x.VinylID });
                    table.ForeignKey(
                        name: "FK_VinylOrders_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VinylOrders_Vinyls_VinylID",
                        column: x => x.VinylID,
                        principalTable: "Vinyls",
                        principalColumn: "VinylID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX__3DDesignOrders__3DDesignID",
                table: "_3DDesignOrders",
                column: "_3DDesignID");

            migrationBuilder.CreateIndex(
                name: "IX__3DPrintOrders__3DPrintID",
                table: "_3DPrintOrders",
                column: "_3DPrintID");

            migrationBuilder.CreateIndex(
                name: "IX_FilamentOrders_FilamentID",
                table: "FilamentOrders",
                column: "FilamentID");

            migrationBuilder.CreateIndex(
                name: "IX_Filaments_ProviderID",
                table: "Filaments",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProviderID",
                table: "Orders",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OtherPurchaseOrders_OtherPurchaseID",
                table: "OtherPurchaseOrders",
                column: "OtherPurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_OtherPurchases_ProviderID",
                table: "OtherPurchases",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_TshirtOrders_TshirtID",
                table: "TshirtOrders",
                column: "TshirtID");

            migrationBuilder.CreateIndex(
                name: "IX_Tshirts_ProviderID",
                table: "Tshirts",
                column: "ProviderID");

            migrationBuilder.CreateIndex(
                name: "IX_VinylOrders_VinylID",
                table: "VinylOrders",
                column: "VinylID");

            migrationBuilder.CreateIndex(
                name: "IX_Vinyls_ProviderID",
                table: "Vinyls",
                column: "ProviderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_3DDesignOrders");

            migrationBuilder.DropTable(
                name: "_3DPrintOrders");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "FilamentOrders");

            migrationBuilder.DropTable(
                name: "OtherPurchaseOrders");

            migrationBuilder.DropTable(
                name: "TshirtOrders");

            migrationBuilder.DropTable(
                name: "VinylOrders");

            migrationBuilder.DropTable(
                name: "_3DDesigns");

            migrationBuilder.DropTable(
                name: "Filaments");

            migrationBuilder.DropTable(
                name: "OtherPurchases");

            migrationBuilder.DropTable(
                name: "Tshirts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Vinyls");

            migrationBuilder.DropTable(
                name: "_3DPrints");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Providers");
        }
    }
}
