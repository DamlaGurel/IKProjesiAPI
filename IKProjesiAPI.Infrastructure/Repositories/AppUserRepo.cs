using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class AppUserRepo : BaseRepo<AppUser>, IAppUserRepo
    {
        private readonly AppDbContext _context;
        public AppUserRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public virtual async Task<SignInResult> PasswordSignInEmail(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                return SignInResult.Failed;
            }

            return SignInResult.Success;
        }

    }
}
