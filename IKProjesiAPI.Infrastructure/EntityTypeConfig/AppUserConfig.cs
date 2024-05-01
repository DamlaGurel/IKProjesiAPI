using IKProjesiAPI.Domain.Entities.AppEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
                CreatedDate = DateTime.Now,
                AccessFailedCount = 0
            };
            var seedSiteManager = new AppUser
            {
                Id = 2,
                FirstName = "SiteManagerName",
                LastName = "SiteManagerLastName",
                Email = "sitemanager@seeddata.com",
                Password = "sitemanager",
                SecurityStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                AccessFailedCount = 0

            };

            var seedCompanyManager = new AppUser
            {
                Id=3,
                FirstName="CompanyManagerName",
                LastName= "CompanyManagerLastName",
                Email="companymanager@seeddata.com",
                Password="companymanager",
                SecurityStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                AccessFailedCount = 0

            };

            var seedEmployee = new AppUser
            {
                Id = 4,
                FirstName = "EmployeeName",
                LastName = "EmployeeLastName",
                Email = "employee@seeddata.com",
                Password = "employee",
                SecurityStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                AccessFailedCount = 0

            };


            superAdmin.PasswordHash = HashPassword(superAdmin, superAdmin.Password);
            seedCompanyManager.PasswordHash = HashPassword(seedCompanyManager, seedCompanyManager.Password);
            seedSiteManager.PasswordHash = HashPassword(seedSiteManager, seedSiteManager.Password);
            seedEmployee.PasswordHash = HashPassword(seedEmployee, seedEmployee.Password);




            builder.HasData(superAdmin, seedCompanyManager, seedSiteManager, seedEmployee);

            base.Configure(builder);
        }

        private string HashPassword(AppUser appUser, string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(appUser, password);
        }
    }
}
