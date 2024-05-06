using Microsoft.AspNetCore.Mvc;
using IKProjesiAPI.Application.Models.DTOs.UserDTOs;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using IKProjesiAPI.Infrastructure.Context;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Application.Services.AppUserService;
using IKProjesiAPI.Application.Models.DTOs;
using Microsoft.AspNetCore.Authorization;

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
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(ClaimTypes.Role, ((Job)role.RoleId).ToString().ToUpper())
                    };

                var token = GetToken(authClaims);
                var tokenString = "Bearer " + new JwtSecurityTokenHandler().WriteToken(token);

                var isValidToken = await ValidateToken();
                var cookieOptions = new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict,
                    Expires = token.ValidTo.AddMinutes(10)
                };
                HttpContext.Response.Cookies.Append("token", tokenString, cookieOptions);

                return Ok(new TokenDto { Token = tokenString, Expiration = token.ValidTo, Role = ((Job)role.RoleId).ToString().ToUpper() });
            }
            else
                return Unauthorized("Kullanıcı yetkisiz");
        }
        [HttpPost]
        [Route("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto changePassword)
        {
            await _appUserService.ChangePassword(changePassword);
            await _context.SaveChangesAsync();
            return Ok("Şifreniz Değiştirildi");
        }

        [HttpGet]
        [Route("ValidateToken")]
        public async Task<IActionResult> ValidateToken()
        {
            var token = HttpContext.Request.Headers["Authorization"].ToString();
            if (!token.IsNullOrEmpty())
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_configuration["JwtSettings:secretKey"]);

                tokenHandler.ValidateToken(token.Replace("Bearer ", ""), new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = _configuration["JwtSettings:validIssuer"],
                    ValidAudience = _configuration["JwtSettings:validAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true
                }, out SecurityToken validatedToken);

                return Ok("Token doğrulandı");
            }
            return Ok();
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