using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
    public class AppUserRoleConfig : BaseEntityConfiguration<AppUserRole>
    {
        public override void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            //builder.HasKey(x => new { x.RoleId, x.UserId });

            builder.HasData(new AppUserRole
            {
                RoleId = 1,
                UserId = 1,
                CreatedDate = DateTime.Now,
                //Status = Status.Active
            });

            base.Configure(builder);
        }
    }
}
