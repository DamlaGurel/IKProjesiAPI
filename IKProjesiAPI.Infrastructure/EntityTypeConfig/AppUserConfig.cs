using IKProjesiAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
    public class AppUserConfig : BaseEntityConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).UseIdentityColumn();
            builder.Property(t => t.FirstName).IsRequired();
            builder.Property(t => t.LastName).IsRequired();
            builder.Property(t => t.Email).IsRequired();
            builder.Property(t => t.Password).IsRequired();

            var superAdmin = new AppUser
            {
                Id = 1,
                FirstName = "Super",
                LastName = "Admin",
                Email = "super@admin.com",
                Password = "admin",
                SecurityStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now
            };

            superAdmin.PasswordHash = HashPassword(superAdmin, superAdmin.Password);

            builder.HasData(superAdmin);

            base.Configure(builder);
        }

        private string HashPassword(AppUser superAdmin, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(superAdmin, password);
        }
    }
}
