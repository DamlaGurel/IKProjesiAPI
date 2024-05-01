using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
    public class AppUserRoleConfig : BaseEntityConfiguration<AppUserRole>
    {
        public override void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasData(new AppUserRole
            {
                RoleId = 1,
                UserId = 1,
                CreatedDate = DateTime.Now,
                Status = Status.Active
            });

            builder.HasData(new AppUserRole
            {
                RoleId = 2,
                UserId = 2,
                CreatedDate = DateTime.Now,
                Status = Status.Active
            });
            builder.HasData(new AppUserRole
            {
                RoleId = 3,
                UserId = 3,
                CreatedDate = DateTime.Now,
                Status = Status.Active
            });
            builder.HasData(new AppUserRole
            {
                RoleId = 4,
                UserId = 4,
                CreatedDate = DateTime.Now,
                Status = Status.Active
            });
            base.Configure(builder);
        }
    }
}
