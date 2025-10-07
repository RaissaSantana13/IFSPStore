using IFSPStoreDomain.Entity;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Context
{
    public class IFSPStoreContext : DbContext
    {
        public IFSPStoreContext() : base()
        { 
            Database.EnsureCreated(); //Create DataBase
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
}
}
