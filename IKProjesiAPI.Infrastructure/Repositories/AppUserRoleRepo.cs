using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class AppUserRoleRepo : BaseRepo<AppUserRole>, IAppUserRoleRepo
    {
        public AppUserRoleRepo(AppDbContext context) : base(context)
        {
        }
    }
}
