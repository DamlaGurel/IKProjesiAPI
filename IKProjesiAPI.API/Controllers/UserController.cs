using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using IKProjesiAPI.Application.Models.DTOs.UserDTOs;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using IKProjesiAPI.Infrastructure.Context;
namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Login(LoginDto model)
        {
            var login = _context.Users.SingleOrDefault(x => x.Email == model.Email && x.PasswordHash == model.Password);
            if (login != null)
            {
                var userClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, model.Email)
            };
                return Ok(userClaims);
            }
            else
                return BadRequest();
        }

    }
}
