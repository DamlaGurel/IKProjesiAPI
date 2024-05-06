using IKProjesiAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
    public class AppCompanyConfig : BaseEntityConfiguration<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(t => t.CompanyName).IsRequired();
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.CompanyManagers)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyId);
           
            var company = new Company
            {
                Id = 1,
                CompanyName = "Company",
                CreatedDate = DateTime.Now,
            };


            builder.HasData(company);

            base.Configure(builder);
        }
    }
}

