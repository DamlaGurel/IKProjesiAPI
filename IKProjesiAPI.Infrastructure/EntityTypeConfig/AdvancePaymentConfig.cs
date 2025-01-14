﻿using IKProjesiAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
	public class AdvancePaymentConfig : IEntityTypeConfiguration<AdvancePayment> 
    {
        public void Configure(EntityTypeBuilder<AdvancePayment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Employee)
                .WithMany(x => x.AdvancePayments)
                .HasForeignKey(x => x.EmployeeId);
        }
    }
}

