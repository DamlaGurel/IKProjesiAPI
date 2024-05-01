using IKProjesiAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
	public class CompanyManagerConfig : BaseEntityConfiguration<CompanyManager>
    {
        public override void Configure(EntityTypeBuilder<CompanyManager> builder)
        {
            builder.HasOne(x => x.Company)
                .WithMany(x=>x.CompanyManagers)
                .HasForeignKey(x=>x.CompanyId);


            base.Configure(builder);

        }
    }
}

