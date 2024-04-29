using IKProjesiAPI.Application.Models.DTOs.UserDTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Services.AppUserService
{
    public interface IAppUserService
    {
        Task<SignInResult> Login(LoginDto model);
        //Task<bool> ForgotPassword(LoginDto model);
        Task LogOut();
    }
}
