using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Application.Services.AppUserService;
using IKProjesiAPI.Application.Services.SiteManagerService;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Text;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
<<<<<<< HEAD
   // [Authorize(AuthenticationSchemes = "Bearer")]
=======
    //[Authorize(AuthenticationSchemes = "Bearer")]
>>>>>>> origin/master
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
            //if (!User.IsInRole(Job.SuperAdmin.ToString().ToUpper()))
            //{
            //    return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            //}

            await _siteManagerService.Create(siteManager);
            var user = await _userManager.FindByNameAsync(siteManager.UserName.ToUpper());
            user.SecurityStamp = Guid.NewGuid().ToString();
            if (user != null)
            {
                string roleName = Job.SiteManager.ToString().ToUpper();
<<<<<<< HEAD
                await _userManager.AddToRoleAsync(user, "SiteManager");
=======
                await _roleManager.RoleExistsAsync(roleName.ToUpper());
                await _userManager.AddToRoleAsync(user, roleName);
>>>>>>> origin/master
            }


            //_roleManager.Roles.Single();

            //if (!await _userManager.IsInRoleAsync(user, "SiteManager"))
            //{ 
            //    await _userManager.AddToRoleAsync(user, "SiteManager"); 
            //}
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
