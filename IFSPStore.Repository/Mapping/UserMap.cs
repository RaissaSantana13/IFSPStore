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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(45);
            builder.Property(x=> x.Password).IsRequired().HasMaxLength(45);
            builder.Property(x => x.Login).IsRequired().HasMaxLength(45);
            builder.Property(x => x.RegisterDate);
            builder.Property(x => x.LoginDate);
            builder.Property(x => x.IsActive);


        }
    }
}
