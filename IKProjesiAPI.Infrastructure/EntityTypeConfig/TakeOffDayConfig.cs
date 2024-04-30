using System;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
	public class TakeOffDayConfig : IEntityTypeConfiguration<TakeOffDay>
    {
        public void Configure(EntityTypeBuilder<TakeOffDay> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Personel)
                .WithMany(x => x.TakeOffDays)
                .HasForeignKey(x => x.PersonelId);
        }
    }
}

