using System;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
    public class AppCompanyConfig : BaseEntityConfiguration<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(t => t.Id);

           
            builder.Property(t => t.CompanyName).IsRequired();



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

