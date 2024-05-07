using IKProjesiAPI.Domain.Entities.AppEntities;
using Microsoft.AspNetCore.Identity;

namespace IKProjesiAPI.Domain.Repositories
{
    public interface IAppUserRepo : IBaseRepo<AppUser>
    {
        Task<SignInResult> PasswordSignInEmail(string email, string password);
        Task<bool> UniqueEmail(string email);
        Task<string> GenerateUniqueEmail(string firstName, string lastName);
    }
}
