using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class ExpenseRepo : BaseEmployeeRepo<Expense>, IExpenseRepo
    {
        public ExpenseRepo(AppDbContext context) : base(context)
        {
        }
    }
}
