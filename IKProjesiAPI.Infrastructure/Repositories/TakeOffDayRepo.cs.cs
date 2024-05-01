using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class TakeOffDayRepo : BaseEmployeeRepo<TakeOffDay>, ITakeOffDayRepo
    {
        public TakeOffDayRepo(AppDbContext context) : base(context)
        {
        }
    }
}
