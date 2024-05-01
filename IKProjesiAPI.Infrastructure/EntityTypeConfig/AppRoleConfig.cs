using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
    public class AppRoleConfig : BaseEntityConfiguration<AppRole>
    {
        public override void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name);

            var superAdmin = new AppRole
            {
                Id = 1,
                Name = "SuperAdmin",
                NormalizedName = "SuperAdmin".ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now
            };

            var siteManager = new AppRole
            {
                Id = 2,
                Name = Job.SiteManager.ToString(),
                NormalizedName = Job.SiteManager.ToString().ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now
            };

            var companyManager = new AppRole
            {
                Id = 3,
                Name = "CompanyManager",
                NormalizedName = "CompanyManager".ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now
            };
            var employee = new AppRole
            {
                Id = 4,
                Name = "Employee",
                NormalizedName = "Employee".ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now
            };

            builder.HasData(superAdmin, siteManager, companyManager, employee);

            base.Configure(builder);
        }
    }
}
