using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace IKProjesiAPI.Domain.Entities.AppEntities
{
    public class AppUserToken : IdentityUserToken<int>, IBaseEntity
    {
        public DateTime? CreatedDate { get ; set ; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status? Status { get; set; }
    }
}
