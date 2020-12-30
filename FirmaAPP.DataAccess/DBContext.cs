using FirmaAPP.BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FirmaAPP.DataAccess
{
    public  class DBContext : DbContext
    {

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Server=DESKTOP-2E6H092;Database=EFCore-FirmaDB;Trusted_Connection=True"); // For Testing
            // optionsBuilder.UseSqlServer("Server=DESKTOP-2E6H092;Database=SRLDB;Trusted_Connection=True"); // The good one
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SetUpOrders(modelBuilder);
            SetUpCustomers(modelBuilder);
            SetUpProviders(modelBuilder);
            SetUpBills(modelBuilder);
            SetUpUsers(modelBuilder);

            SetUpFilaments(modelBuilder);
            SetUpFilamentOrders(modelBuilder);

            SetUpOtherPurchases(modelBuilder);
            SetUpOtherPurchaseOrders(modelBuilder);

            SetUpVinyls(modelBuilder);
            SetUpVinylOrders(modelBuilder);

            SetUpTshirts(modelBuilder);
            SetUpTshirtOrders(modelBuilder);

            SetUp_3DDesigns(modelBuilder);
            SetUp_3DDesignOrders(modelBuilder);

            SetUp_3DPrints(modelBuilder);
            SetUp_3DPrintOrders(modelBuilder);

            SetUpAppSettings(modelBuilder);
            SetUpBusinessDetails(modelBuilder);
        }

        #region SetUpDB

        private void SetUpOrders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().Ignore(f => f.ProviderName);
            modelBuilder.Entity<Order>().Ignore(f => f.BillName);
            modelBuilder.Entity<Order>().Ignore(f => f.BillStatus);
            modelBuilder.Entity<Order>().Ignore(f => f.UserName);
            modelBuilder.Entity<Order>().Ignore(f => f.CustomerName);
            modelBuilder.Entity<Order>().HasIndex(b => b.BillID).IsUnique(false);
        }

        private void SetUpCustomers(ModelBuilder modelBuilder)
        {
            // Set up One-to-Many relationship with Orders
            modelBuilder.Entity<Customer>()
            .HasMany<Order>(c => c.Orders)
            .WithOne(o => o.Customer)
            .HasForeignKey(o => o.CustomerID);
        }

        private void SetUpProviders(ModelBuilder modelBuilder)
        {
            // Set up One-to-Many relationship with Orders
            modelBuilder.Entity<Provider>()
            .HasMany<Order>(p => p.Orders)
            .WithOne(o => o.Provider)
            .HasForeignKey(o => o.ProviderID);
        }

        private void SetUpBills(ModelBuilder modelBuilder)
        {
            // Set up One-to-One relationship with Orders

            modelBuilder.Entity<Bill>()
            .HasOne<Order>(b => b._order)
            .WithOne(o => o.Bill)
            .HasForeignKey<Order>(o => o.BillID);
            //.OnDelete(DeleteBehavior.SetNull);
        }

        private void SetUpUsers(ModelBuilder modelBuilder)
        {
            // Set up One-to-Many relationship with Orders
            modelBuilder.Entity<User>()
            .HasMany<Order>(u => u.Orders)
            .WithOne(o => o.User)
            .HasForeignKey(o => o.UserID);
        }

        private void SetUpFilaments(ModelBuilder modelBuilder)
        {
            // Set up One-to-Many relationship with Provider
            modelBuilder.Entity<Filament>()
                .HasOne<Provider>(s => s.Provider)
                .WithMany(g => g.Filaments)
                .HasForeignKey(s => s.ProviderID);
            modelBuilder.Entity<Filament>().Ignore(f => f.ProviderName);
            modelBuilder.Entity<Filament>().Ignore(f => f.Provider);
        }

        private void SetUpFilamentOrders(ModelBuilder modelBuilder)
        {
            //Set up Many-to-Many relationship
            modelBuilder.Entity<FilamentOrder>().HasKey(fo => new {fo.FilamentOrderID, fo.OrderID, fo.FilamentID });

            modelBuilder.Entity<FilamentOrder>()
                .HasOne<Order>(fo => fo.Order)
                .WithMany(s => s._filamentOrders)
                .HasForeignKey(fo => fo.OrderID);


            modelBuilder.Entity<FilamentOrder>()
                .HasOne<Filament>(fo => fo.Filament)
                .WithMany(s => s._filamentOrders)
                .HasForeignKey(fo => fo.FilamentID);
        }

        private void SetUpOtherPurchases(ModelBuilder modelBuilder)
        {
            // Set up One-to-Many relationship with Provider
            modelBuilder.Entity<OtherPurchase>()
                .HasOne<Provider>(s => s.Provider)
                .WithMany(g => g.OtherPurchases)
                .HasForeignKey(s => s.ProviderID);
            modelBuilder.Entity<OtherPurchase>().Ignore(f => f.ProviderName);
            modelBuilder.Entity<OtherPurchase>().Ignore(f => f.Provider);
        }

        private void SetUpOtherPurchaseOrders(ModelBuilder modelBuilder)
        {
            //Set up Many-to-Many relationship
            modelBuilder.Entity<OtherPurchaseOrder>().HasKey(opo => new {opo.OtherPurchaseOrderID, opo.OrderID, opo.OtherPurchaseID });

            modelBuilder.Entity<OtherPurchaseOrder>()
                .HasOne<Order>(opo => opo.Order)
                .WithMany(o => o._otherPurchaseOrders)
                .HasForeignKey(opo => opo.OrderID);


            modelBuilder.Entity<OtherPurchaseOrder>()
                .HasOne<OtherPurchase>(opo => opo.OtherPurchase)
                .WithMany(op => op._otherPurchaseOrders)
                .HasForeignKey(opo => opo.OtherPurchaseID);
        }

        private void SetUpVinyls(ModelBuilder modelBuilder)
        {
            // Set up One-to-Many relationship with Provider
            modelBuilder.Entity<Vinyl>()
                .HasOne<Provider>(s => s.Provider)
                .WithMany(g => g.Vinyls)
                .HasForeignKey(s => s.ProviderID);
            modelBuilder.Entity<Vinyl>().Ignore(f => f.ProviderName);
            modelBuilder.Entity<Vinyl>().Ignore(f => f.Provider);
        }

        private void SetUpVinylOrders(ModelBuilder modelBuilder)
        {
            //Set up Many-to-Many relationship
            

            modelBuilder.Entity<VinylOrder>().HasKey(vo => new {vo.VinylOrderID , vo.OrderID, vo.VinylID });
            
            modelBuilder.Entity<VinylOrder>()
                .HasOne<Order>(vo => vo.Order)
                .WithMany(o => o._vinylOrders)
                .HasForeignKey(vo => vo.OrderID);


            modelBuilder.Entity<VinylOrder>()
                .HasOne<Vinyl>(vo => vo.Vinyl)
                .WithMany(op => op._vinylOrders)
                .HasForeignKey(vo => vo.VinylID);
        }

        private void SetUpTshirts(ModelBuilder modelBuilder)
        {
            // Set up One-to-Many relationship with Provider
            modelBuilder.Entity<Tshirt>()
                .HasOne<Provider>(s => s.Provider)
                .WithMany(g => g.Tshirts)
                .HasForeignKey(s => s.ProviderID);
            modelBuilder.Entity<Tshirt>().Ignore(f => f.ProviderName);
            modelBuilder.Entity<Tshirt>().Ignore(f => f.Provider);
        }

        private void SetUpTshirtOrders(ModelBuilder modelBuilder)
        {
            //Set up Many-to-Many relationship
            modelBuilder.Entity<TshirtOrder>().HasKey(to => new {to.TshirtOrderID, to.OrderID});
           
           modelBuilder.Entity<TshirtOrder>()
                .HasOne<Order>(to => to.Order)
                .WithMany(o => o._tshirtOrders)
                .HasForeignKey(to => to.OrderID);


            modelBuilder.Entity<TshirtOrder>()
                .HasOne<Tshirt>(to => to.Tshirt)
                .WithMany(op => op._tshirtOrders)
                .HasForeignKey(to => to.TshirtID);

        }

        private void SetUp_3DDesigns(ModelBuilder modelBuilder)
        {
            //TO DO: Remove this
            // modelBuilder.Entity<_3DDesign>().ide
            modelBuilder.Entity<_3DDesign>().Ignore(f => f.Id);
        }

        private void SetUp_3DDesignOrders(ModelBuilder modelBuilder)
        {
            ////Set up Many-to-Many relationship
            modelBuilder.Entity<_3DDesignOrder>().HasKey(_3dd => new { _3dd._3DDesignOrderID, _3dd.OrderID, _3dd._3DDesignID });

            modelBuilder.Entity<_3DDesignOrder>()
                .HasOne<Order>(_3dd => _3dd.Order)
                .WithMany(o => o._3DDesignOrders)
                .HasForeignKey(_3dd => _3dd.OrderID);

            modelBuilder.Entity<_3DDesignOrder>()
                .HasOne<_3DDesign>(_3dd => _3dd._3DDesign)
                .WithMany(op => op._3DDesignOrders)
                .HasForeignKey(_3dd => _3dd._3DDesignID);

        }

        private void SetUp_3DPrints(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_3DPrint>().Ignore(f => f._3DDesignName);
        }

        private void SetUp_3DPrintOrders(ModelBuilder modelBuilder)
        {
            //Set up Many-to-Many relationship
            modelBuilder.Entity<_3DPrintOrder>().HasKey(_3dd => new {_3dd._3DPrintOrderID, _3dd.OrderID, _3dd._3DPrintID });

            modelBuilder.Entity<_3DPrintOrder>()
                .HasOne<Order>(_3dd => _3dd.Order)
                .WithMany(o => o._3DPrintOrders)
                .HasForeignKey(_3dd => _3dd.OrderID);

            modelBuilder.Entity<_3DPrintOrder>()
                .HasOne<_3DPrint>(_3dd => _3dd._3DPrint)
                .WithMany(op => op._3DPrintOrders)
                .HasForeignKey(_3dd => _3dd._3DPrintID);
        }

        private void SetUpAppSettings(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne<AppSettings>(a => a.AppSettings)
                .WithOne(u => u._user)
                .HasForeignKey<AppSettings>(u => u.UserID);
        }

        private void SetUpBusinessDetails(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasOne<BusinessDetails>(a => a.BusinessDetails)
            .WithOne(u => u._user)
            .HasForeignKey<BusinessDetails>(u => u.UserID);
        }
        #endregion


        #region DBSet
        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Filament> Filaments { get; set; }
        public DbSet<FilamentOrder> FilamentOrders { get; set; }

        public DbSet<OtherPurchase> OtherPurchases { get; set; }
        public DbSet<OtherPurchaseOrder> OtherPurchaseOrders { get; set; }

        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<VinylOrder> VinylOrders { get; set; }

        public DbSet<Tshirt> Tshirts { get; set; }
        public DbSet<TshirtOrder> TshirtOrders { get; set; }

        public DbSet<_3DDesign> _3DDesigns { get; set; }
        public DbSet<_3DDesignOrder> _3DDesignOrders { get; set; }

        public DbSet<_3DPrint> _3DPrints { get; set; }
        public DbSet<_3DPrintOrder> _3DPrintOrders { get; set; }

        public DbSet<AppSettings> AppSettings { get; set; }
        public DbSet<BusinessDetails> BusinessDetails { get; set; }
        #endregion
    }
}
