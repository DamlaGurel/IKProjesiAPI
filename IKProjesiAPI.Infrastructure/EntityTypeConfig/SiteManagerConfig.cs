using System;
using IKProjesiAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
	public class SiteManagerConfig : BaseEntityConfiguration<SiteManager>
    {
        public override void Configure(EntityTypeBuilder<SiteManager> builder)
        {
            base.Configure(builder);
        }
    }
}

