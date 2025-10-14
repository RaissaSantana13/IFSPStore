using IFSPStore.Repository.Mapping;
using IFSPStoreDomain.Entity;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Context
{
    public class IFSPStoreContext : DbContext
    {
        public IFSPStoreContext() : base()
        { 
            //Database.EnsureCreated(); //Create DataBase
        }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost; database=IFSPStore; user=root; password=");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<Sale> Sales{ get; set; }
        public DbSet<SaleItem> SaleItems{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>(new CategoryMap().Configure);
            modelBuilder.Entity<City>(new CityMap().Configure);
            modelBuilder.Entity<Costumer>(new CostumerMap().Configure);
            modelBuilder.Entity<Product>(new ProductMap().Configure);
            modelBuilder.Entity<Sale>(new SaleMap().Configure);
            modelBuilder.Entity<SaleItem>(new SaleItemMap().Configure);
            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
