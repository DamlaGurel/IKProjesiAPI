using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class SiteManagerRepo : BaseRepo<SiteManager>, ISiteManagerRepo
    {
        public SiteManagerRepo(AppDbContext context) : base(context)
        {
        }

    }
}
