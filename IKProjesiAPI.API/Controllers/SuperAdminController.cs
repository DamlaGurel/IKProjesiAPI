using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Application.Services.SiteManagerService;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Bearer")]

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

        [HttpPost]
        [Route("CreateSiteManager")]
        //[Authorize(Roles = "SUPERADMİN")]
        public async Task<IActionResult> CreateSiteManager([FromBody] CreateSiteManagerDto siteManager)
        {
            //if (!User.IsInRole(Job.SuperAdmin.ToString().ToUpper()))
            //{
            //    return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            //}

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sm = await _siteManagerService.CreateSiteManager(siteManager);
            var user = await _userManager.FindByNameAsync(sm.UserName.ToUpper());
            user.SecurityStamp = Guid.NewGuid().ToString();
            
            if (user != null)
            {
                string roleName = Job.SiteManager.ToString().ToUpper();
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
            await _siteManagerService.DeleteSiteManager(id);
            return Ok("SİLME BAŞARILI");
        }

        [HttpGet]
        [Route("SiteManagerDetail")]
        public async Task<IActionResult> SiteManagerDetail()
        {
            var siteManager = await _siteManagerService.SiteManagerDetails();
            return Ok(siteManager);
        }
    }
}
