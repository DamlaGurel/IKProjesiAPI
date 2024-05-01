using IKProjesiAPI.Application.Models.DTOs.UserDTOs;
using Microsoft.AspNetCore.Identity;

namespace IKProjesiAPI.Application.Services.AppUserService
{
    public interface IAppUserService
    {
        Task<SignInResult> Login(LoginDto model);
        //Task<bool> ForgotPassword(LoginDto model);
        Task ChangePassword(ChangePasswordDto password);
        Task LogOut();
    }
}
