using IKProjesiAPI.Domain.Entities.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
    internal class AppRoleConfig : BaseEntityConfiguration<AppRole>
    {
        public override void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name);

            var admin = new AppRole
            {
                Id = 1,
                Name = "SuperAdmin",
                NormalizedName = "SuperAdmin".ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now
            };

            builder.HasData(admin);

            base.Configure(builder);
        }
    }
}
