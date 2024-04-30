using System;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
	public class PersonelConfig : BaseEntityConfiguration<Personel>
    {
        public override void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasOne(x => x.Company)
                .WithMany(x => x.Personels)
                .HasForeignKey(x => x.CompanyId);

            builder.HasMany(x => x.AdvancePayments)
             .WithOne(x => x.Personel)
             .HasForeignKey(x => x.PersonelId);

            builder.HasMany(x => x.Expenses)
            .WithOne(x => x.Personel)
            .HasForeignKey(x => x.PersonelId);

            builder.HasMany(x => x.TakeOffDays)
            .WithOne(x => x.Personel)
            .HasForeignKey(x => x.PersonelId);

            base.Configure(builder);
            
        }
    }

}

