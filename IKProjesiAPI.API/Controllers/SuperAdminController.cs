using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Application.Services.AppUserService;
using IKProjesiAPI.Application.Services.SiteManagerService;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class SuperAdminController : ControllerBase
    {
        private readonly ISiteManagerService _siteManagerService;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public SuperAdminController(ISiteManagerService siteManagerService, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _siteManagerService = siteManagerService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost("CreateSiteManager")]
        public async Task<IActionResult> CreateSiteManager([FromBody] CreateSiteManagerDto siteManager)
        {
            await _siteManagerService.Create(siteManager);

            var user = await _userManager.FindByNameAsync(siteManager.FirstName);

            if (user != null)
            {
                string roleName = "SiteManager";
                var role = await _roleManager.FindByNameAsync(roleName);
                if (!await _roleManager.RoleExistsAsync(roleName))
                {
                    role = new AppRole { Name = roleName };
                    await _roleManager.CreateAsync(role);
                }

                // Kullanıcıya rolü ata
                await _userManager.AddToRoleAsync(user, roleName);
            }
            return Ok("KAYIT BAŞARILI");
        }

        //[HttpPut]
        //public IActionResult UpdateSiteManager(SiteManagerUpdateDto siteManager)
        //{
        //    return Ok(_siteManagerService.Update(siteManager));
        //}

        [HttpDelete("DeleteSiteManager")]
        public async Task<IActionResult> DeleteSiteManager(int id)
        {
            await _siteManagerService.Delete(id);
            return Ok("SİLME BAŞARILI");
        }

    }
}
