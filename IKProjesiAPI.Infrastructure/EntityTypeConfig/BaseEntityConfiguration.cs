﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using IKProjesiAPI.Domain.Entities;

namespace IKProjesiAPI.Infrastructure.EntityTypeConfig
{
    public abstract class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IBaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired(false);
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.DeletedDate).IsRequired(false);

            
        }
    }
}
