using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class AppUserRepo : BaseRepo<AppUser>, IAppUserRepo
    {
        private readonly AppDbContext _context;
        public AppUserRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<string> GenerateUniqueEmail(string firstName, string lastName)
        {
            int count = 1;
            string turkishFirstName = ReplaceTurkishCharacters(firstName);
            string turkishLastName = ReplaceTurkishCharacters(lastName);
            string Email = $"{turkishFirstName.ToLower()}.{turkishLastName.ToLower()}@bilgeadamboost.com";

            while (await UniqueEmail(Email))
            {
                count++;
                Email = $"{firstName.ToLower()}.{lastName.ToLower()}{count}@bilgeadamboost.com";
            }

            return Email;
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
        public async Task<bool> UniqueEmail(string email)
        {
            var user = await _context.Users.AnyAsync(u => u.Email == email);
            return user;
        }

        public static string ReplaceTurkishCharacters(string input)
        {
            var turkishChars = new Dictionary<char, char>
                                                        {
                                                          {'ç', 'c'}, {'Ç', 'C'},
                                                          {'ğ', 'g'}, {'Ğ', 'G'},
                                                          {'ı', 'i'}, {'İ', 'I'},
                                                          {'ö', 'o'}, {'Ö', 'O'},
                                                          {'ş', 's'}, {'Ş', 'S'},
                                                          {'ü', 'u'}, {'Ü', 'U'},
                                                        };

            var result = new StringBuilder();
            foreach (var c in input)
            {
                if (turkishChars.ContainsKey(c))
                    result.Append(turkishChars[c]);
                else
                    result.Append(c);
            }

            return result.ToString();
        }


    }
}
