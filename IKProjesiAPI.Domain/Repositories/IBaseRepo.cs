using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Domain.Repositories
{
    public interface IBaseRepo<T> where T : IBaseEntity
    {
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
