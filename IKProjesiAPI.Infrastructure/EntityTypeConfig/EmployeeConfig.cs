using System;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
	public class EmployeeConfig : BaseEntityConfiguration<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasOne(x => x.CompanyManager)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.CompanyManagerId);

            builder.HasMany(x => x.AdvancePayments)
             .WithOne(x => x.Employee)
             .HasForeignKey(x => x.EmployeeId);

            builder.HasMany(x => x.Expenses)
            .WithOne(x => x.Employee)
            .HasForeignKey(x => x.EmployeeId);

            builder.HasMany(x => x.TakeOffDays)
            .WithOne(x => x.Employee)
            .HasForeignKey(x => x.EmployeeId);

            base.Configure(builder);
            
        }
    }

}

