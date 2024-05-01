using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class CompanyManagerRepo : BaseRepo<CompanyManager>, ICompanyManagerRepo
    {
        public CompanyManagerRepo(AppDbContext context) : base(context)
        {
        }
    }
}

