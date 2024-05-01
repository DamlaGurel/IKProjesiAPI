using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class EmployeeRepo : BaseRepo<Employee>, IEmployeeRepo
    {
        public EmployeeRepo(AppDbContext context) : base(context)
        {
        }
    }
}
