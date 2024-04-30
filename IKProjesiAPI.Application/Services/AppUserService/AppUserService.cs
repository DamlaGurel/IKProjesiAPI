using IKProjesiAPI.Application.Models.DTOs.UserDTOs;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Services.AppUserService
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserRepo _repo;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AppUserService(IAppUserRepo repo, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _repo = repo;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task ChangePassword(ChangePasswordDto password)
        {
            var userMail = await _repo.GetFilteredFirstOrDefault(select: x => x.Email,
                                                                 where: x => x.TemporaryPassword == password.TemporaryPassword);

            var user = await _userManager.FindByEmailAsync(userMail);

            await _userManager.ChangePasswordAsync(user, password.TemporaryPassword, password.NewPassword);
            user.Password = password.NewPassword;
        }

        //public async Task<bool> ForgotPassword(LoginDto model)
        //{
        //    var user = await _userManager.FindByEmailAsync(model.Email);
        //    return user;
        //}

        public async Task<SignInResult> Login(LoginDto model)
        {
            var result = await _repo.PasswordSignInEmail(model.Email, model.Password);
            return result;
        }

        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }

        

    }
}
