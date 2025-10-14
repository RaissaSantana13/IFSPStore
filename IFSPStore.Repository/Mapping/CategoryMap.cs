using IFSPStoreDomain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.BouncyCastle.Asn1.IsisMtt.X509;

namespace IFSPStore.Repository.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name).IsRequired().HasMaxLength(50); // .HasColumnTipe("VarChar(50)")
            builder.Property(prop => prop.Description).IsRequired().HasMaxLength(1000);
        }
    }
}
