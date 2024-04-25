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
namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        public UserController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            var login = _context.AppUsers.SingleOrDefault(a => a.Email == model.Email && a.Password == model.Password);

            if (login != null)
            {
                var roles = _context.AppUserRoles.Where(x => x.UserId == login.Id).ToList();
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, login.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
                if (roles.Any())
                {
                    foreach(var role in roles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, ((Job)role.RoleId).ToString().ToUpper()));
                    }
                }

                var token = GetToken(authClaims);

                var cookieOptions = new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict,
                    Expires = token.ValidTo.AddMinutes(10)
                };
                HttpContext.Response.Cookies.Append("auth_token", new JwtSecurityTokenHandler().WriteToken(token), cookieOptions);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
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
    }
}
