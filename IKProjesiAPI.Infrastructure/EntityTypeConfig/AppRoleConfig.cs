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
                Name = Job.SUPERADMIN.ToString(),
                NormalizedName = Job.SUPERADMIN.ToString().ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now
            };

            var siteManager = new AppRole
            {
                Id = 2,
                Name = Job.SITEMANAGER.ToString(),
                NormalizedName = Job.SITEMANAGER.ToString().ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now
            };

            var companyManager = new AppRole
            {
                Id = 3,
                Name = Job.COMPANYMANAGER.ToString(),
                NormalizedName = Job.COMPANYMANAGER.ToString().ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now
            };
            var employee = new AppRole
            {
                Id = 4,
                Name = Job.EMPLOYEE.ToString(),
                NormalizedName = Job.EMPLOYEE.ToString().ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now
            };

            builder.HasData(superAdmin, siteManager, companyManager, employee);

            base.Configure(builder);
        }
    }
}
