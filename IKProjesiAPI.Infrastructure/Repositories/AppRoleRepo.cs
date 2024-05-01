using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class AppRoleRepo : BaseRepo<AppRole>, IAppRoleRepo
    {
        public AppRoleRepo(AppDbContext context) : base(context)
        {
        }
    }
}
