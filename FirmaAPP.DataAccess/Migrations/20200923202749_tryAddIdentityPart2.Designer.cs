﻿// <auto-generated />
using System;
using FirmaAPP.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FirmaAPP.DataAccess.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20200923202749_tryAddIdentityPart2")]
    partial class tryAddIdentityPart2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FirmaAPP.BusinessObject.Bill", b =>
                {
                    b.Property<int>("BillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("BillStatus")
                        .HasColumnType("smallint");

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("BillID");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CUI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IBAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<bool>("TVAPaying")
                        .HasColumnType("bit");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.Filament", b =>
                {
                    b.Property<int>("FilamentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProviderID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<float>("Stock")
                        .HasColumnType("real");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("FilamentID");

                    b.HasIndex("ProviderID");

                    b.ToTable("Filaments");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.FilamentOrder", b =>
                {
                    b.Property<int>("FilamentOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("FilamentID")
                        .HasColumnType("int");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("FilamentOrderID", "OrderID", "FilamentID");

                    b.HasIndex("FilamentID");

                    b.HasIndex("OrderID");

                    b.ToTable("FilamentOrders");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BillID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeadLineDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FinalizeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int>("OrderType")
                        .HasColumnType("int");

                    b.Property<int?>("ProviderID")
                        .HasColumnType("int");

                    b.Property<float>("ShippingPrice")
                        .HasColumnType("real");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("BillID")
                        .IsUnique()
                        .HasFilter("[BillID] IS NOT NULL");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProviderID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.OtherPurchase", b =>
                {
                    b.Property<int>("OtherPurchaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProviderID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<float?>("Stock")
                        .HasColumnType("real");

                    b.HasKey("OtherPurchaseID");

                    b.HasIndex("ProviderID");

                    b.ToTable("OtherPurchases");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.OtherPurchaseOrder", b =>
                {
                    b.Property<int>("OtherPurchaseOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("OtherPurchaseID")
                        .HasColumnType("int");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("OtherPurchaseOrderID", "OrderID", "OtherPurchaseID");

                    b.HasIndex("OrderID");

                    b.HasIndex("OtherPurchaseID");

                    b.ToTable("OtherPurchaseOrders");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.Provider", b =>
                {
                    b.Property<int>("ProviderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CUI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IBAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<bool>("TVAPaying")
                        .HasColumnType("bit");

                    b.HasKey("ProviderID");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.Tshirt", b =>
                {
                    b.Property<int>("TshirtID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProviderID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("TshirtID");

                    b.HasIndex("ProviderID");

                    b.ToTable("Tshirts");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.TshirtOrder", b =>
                {
                    b.Property<int>("TshirtOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int?>("VinylID")
                        .HasColumnType("int");

                    b.Property<short>("PrintingType")
                        .HasColumnType("smallint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<int>("TshirtID")
                        .HasColumnType("int");

                    b.HasKey("TshirtOrderID", "OrderID", "VinylID");

                    b.HasIndex("OrderID");

                    b.HasIndex("TshirtID");

                    b.ToTable("TshirtOrders");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.Vinyl", b =>
                {
                    b.Property<int>("VinylID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProviderID")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<float>("Stock")
                        .HasColumnType("real");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("VinylID");

                    b.HasIndex("ProviderID");

                    b.ToTable("Vinyls");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.VinylOrder", b =>
                {
                    b.Property<int>("VinylOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("VinylID")
                        .HasColumnType("int");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("VinylOrderID", "OrderID", "VinylID");

                    b.HasIndex("OrderID");

                    b.HasIndex("VinylID");

                    b.ToTable("VinylOrders");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject._3DDesign", b =>
                {
                    b.Property<int>("_3DDesignID")
                        .HasColumnType("int");

                    b.Property<short>("DesignStatus")
                        .HasColumnType("smallint");

                    b.Property<int>("EstimatedDesignTime")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FinalizeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HoursWork")
                        .HasColumnType("int");

                    b.Property<int>("RealDesignTime")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("_3DPrintID")
                        .HasColumnType("int");

                    b.HasKey("_3DDesignID");

                    b.ToTable("_3DDesigns");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject._3DDesignOrder", b =>
                {
                    b.Property<int>("_3DDesignOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("_3DDesignID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("_3DDesignOrderID", "OrderID", "_3DDesignID");

                    b.HasIndex("OrderID");

                    b.HasIndex("_3DDesignID");

                    b.ToTable("_3DDesignOrders");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject._3DPrint", b =>
                {
                    b.Property<int>("_3DPrintID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FileGCode")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Rating")
                        .HasColumnType("smallint");

                    b.Property<int?>("_3DDesignID")
                        .HasColumnType("int");

                    b.HasKey("_3DPrintID");

                    b.ToTable("_3DPrints");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject._3DPrintOrder", b =>
                {
                    b.Property<int>("_3DPrintOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("_3DPrintID")
                        .HasColumnType("int");

                    b.Property<short>("Color")
                        .HasColumnType("smallint");

                    b.Property<int?>("FilamentID")
                        .HasColumnType("int");

                    b.Property<short>("Infill")
                        .HasColumnType("smallint");

                    b.Property<int>("PrintingTimeInMin")
                        .HasColumnType("int");

                    b.Property<int>("PrintsQuantity")
                        .HasColumnType("int");

                    b.Property<short>("Quality")
                        .HasColumnType("smallint");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<float>("Wheight")
                        .HasColumnType("real");

                    b.HasKey("_3DPrintOrderID", "OrderID", "_3DPrintID");

                    b.HasIndex("OrderID");

                    b.HasIndex("_3DPrintID");

                    b.ToTable("_3DPrintOrders");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.Filament", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject.Provider", null)
                        .WithMany("Filaments")
                        .HasForeignKey("ProviderID");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.FilamentOrder", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject.Filament", "Filament")
                        .WithMany("_filamentOrders")
                        .HasForeignKey("FilamentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirmaAPP.BusinessObject.Order", "Order")
                        .WithMany("_filamentOrders")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.Order", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject.Bill", "Bill")
                        .WithOne("_order")
                        .HasForeignKey("FirmaAPP.BusinessObject.Order", "BillID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("FirmaAPP.BusinessObject.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID");

                    b.HasOne("FirmaAPP.BusinessObject.Provider", "Provider")
                        .WithMany("Orders")
                        .HasForeignKey("ProviderID");

                    b.HasOne("FirmaAPP.BusinessObject.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.OtherPurchase", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject.Provider", null)
                        .WithMany("OtherPurchases")
                        .HasForeignKey("ProviderID");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.OtherPurchaseOrder", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject.Order", "Order")
                        .WithMany("_otherPurchaseOrders")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirmaAPP.BusinessObject.OtherPurchase", "OtherPurchase")
                        .WithMany("_otherPurchaseOrders")
                        .HasForeignKey("OtherPurchaseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.Tshirt", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject.Provider", null)
                        .WithMany("Tshirts")
                        .HasForeignKey("ProviderID");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.TshirtOrder", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject.Order", "Order")
                        .WithMany("_tshirtOrders")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirmaAPP.BusinessObject.Tshirt", "Tshirt")
                        .WithMany("_tshirtOrders")
                        .HasForeignKey("TshirtID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.Vinyl", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject.Provider", null)
                        .WithMany("Vinyls")
                        .HasForeignKey("ProviderID");
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject.VinylOrder", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject.Order", "Order")
                        .WithMany("_vinylOrders")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirmaAPP.BusinessObject.Vinyl", "Vinyl")
                        .WithMany("_vinylOrders")
                        .HasForeignKey("VinylID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject._3DDesign", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject._3DPrint", "_3DPrint")
                        .WithOne("_3DDesign")
                        .HasForeignKey("FirmaAPP.BusinessObject._3DDesign", "_3DDesignID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject._3DDesignOrder", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject.Order", "Order")
                        .WithMany("_3DDesignOrders")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirmaAPP.BusinessObject._3DDesign", "_3DDesign")
                        .WithMany("_3DDesignOrders")
                        .HasForeignKey("_3DDesignID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FirmaAPP.BusinessObject._3DPrintOrder", b =>
                {
                    b.HasOne("FirmaAPP.BusinessObject.Order", "Order")
                        .WithMany("_3DPrintOrders")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirmaAPP.BusinessObject._3DPrint", "_3DPrint")
                        .WithMany("_3DPrintOrders")
                        .HasForeignKey("_3DPrintID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
