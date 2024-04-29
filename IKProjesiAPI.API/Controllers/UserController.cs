using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using IKProjesiAPI.Application.Models.DTOs.UserDTOs;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using IKProjesiAPI.Infrastructure.Context;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;
using NuGet.Common;
using IKProjesiAPI.Application.Services.AppUserService;
using IKProjesiAPI.Application.Models.DTOs;
using System.Data;
namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IAppUserService _appUserService;

        public UserController(AppDbContext context, IConfiguration configuration, IAppUserService appUserService)
        {
            _context = context;
            _configuration = configuration;
            _appUserService = appUserService;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            var login = _context.AppUsers.SingleOrDefault(a => a.Email == model.Email && a.Password == model.Password);

            if (login != null)
            {
                await _appUserService.Login(model);

                var role = await _context.AppUserRoles.FirstAsync(x => x.UserId == login.Id);
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, login.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var token = GetToken(authClaims);
                var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                var cookieOptions = new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict,
                    Expires = token.ValidTo.AddMinutes(10)
                };
                HttpContext.Response.Cookies.Append("token", tokenString, cookieOptions);

                return Ok(new TokenDto{ Token = tokenString, Expiration = token.ValidTo, Role = ((Job)role.RoleId).ToString().ToUpper() });

            }
            else
                return Unauthorized("Kullanıcı yetkisiz");
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:secretKey"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:validIssuer"],
                audience: _configuration["JwtSettings:validAudience"],
                claims: authClaims,
                expires: DateTime.UtcNow.AddMinutes(10),
                signingCredentials: signIn
                );
            return token;
        }
        [HttpGet]
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _appUserService.LogOut();
            return Ok();
        }
    }
}
