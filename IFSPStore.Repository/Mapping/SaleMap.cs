using IFSPStoreDomain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Mapping 
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SaleDate);
            builder.Property(x => x.SaleTotal);
            builder.HasOne(x => x.Salesman);
            builder.HasOne(x => x.Costumer);
            builder.HasMany(x => x.SaleItems).WithOne(x => x.Sale).OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TotalPrice);
            builder.Property(x => x.Quantity);
            builder.Property(x => x.TotalPrice);
            builder.Property(x => x.UnitPrice);
            builder.HasOne(x => x.Product);
            builder.HasOne(x => x.Sale).WithMany(x => x.SaleItems).OnDelete(DeleteBehavior.Cascade);
        }
    }
}


