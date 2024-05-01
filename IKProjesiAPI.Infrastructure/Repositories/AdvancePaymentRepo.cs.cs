using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class AdvancePaymentRepo : BaseEmployeeRepo<AdvancePayment>, IAdvancePaymentRepo
    {
        public AdvancePaymentRepo(AppDbContext context) : base(context)
        {
        }
    }
}
