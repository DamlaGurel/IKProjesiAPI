using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class, IBaseEntity
    {
        private readonly AppDbContext _context;
        protected DbSet<T> _dbSet;
        public BaseRepo(AppDbContext context) 
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task Create(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
