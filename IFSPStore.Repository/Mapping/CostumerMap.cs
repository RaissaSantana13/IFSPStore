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
    public class CostumerMap : IEntityTypeConfiguration<Costumer>
    {
        public void Configure(EntityTypeBuilder<Costumer> builder)
        {
            builder.ToTable("Costumer");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name).IsRequired().HasMaxLength(100);
            builder.Property(prop => prop.Address).IsRequired().HasMaxLength(100);
            builder.Property(prop => prop.Document).IsRequired().HasMaxLength(45);
            builder.Property(prop => prop.District).IsRequired().HasMaxLength(45);
            builder.HasOne(prop => prop.City);


        }
    }
}
