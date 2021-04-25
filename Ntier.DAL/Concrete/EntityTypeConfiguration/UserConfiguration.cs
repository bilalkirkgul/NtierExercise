using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ntier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.DAL.Concrete.EntityTypeConfiguration
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).ValueGeneratedOnAdd();

            builder.Property(a => a.FirstName).HasMaxLength(20).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(25).IsRequired();
            builder.Property(a => a.Password).IsRequired().IsRequired();


            builder.HasData(new User
            {
                ID = 1,
                FirstName = "admin",
                LastName = "admin",
                Password = "admin",
                KullanıcıRole = Model.Enum.KullaniciRole.admin


            });
        }
    }
}
