﻿using IKProjesiAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace IKProjesiAPI.Domain.Repositories
{
    public interface IBaseEmployeeRepo<T> where T : IBaseEmployee
    {
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<T> GetDefault(Expression<Func<T, bool>> expression);
        Task<List<T>> GetDefaults(Expression<Func<T, bool>> expression);
        Task<bool> Any(Expression<Func<T, bool>> expression);
        Task<TResult> GetFilteredFirstOrDefault<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }
}
