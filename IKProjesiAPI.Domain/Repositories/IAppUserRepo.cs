using IKProjesiAPI.Domain.Entities.AppEntities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Domain.Repositories
{
    public interface IAppUserRepo : IBaseRepo<AppUser>
    {
        Task<SignInResult> PasswordSignInEmail(string email, string password);
    }
}
