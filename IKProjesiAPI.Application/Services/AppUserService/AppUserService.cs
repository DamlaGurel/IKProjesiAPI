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

        //public async Task<bool> ForgotPassword(LoginDto model)
        //{
        //    var user = await _userManager.FindByEmailAsync(model.Email);
        //    return user;
        //}

        public async Task<SignInResult> Login(LoginDto model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password,false,false);
            return result;
        }

        //public async Task LogOut()
        //{
        //    return await _signInManager.SignOutAsync();
        //}
    }
}
