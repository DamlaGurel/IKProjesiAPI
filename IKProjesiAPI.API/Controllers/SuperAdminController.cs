using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Application.Services.SiteManagerService;
using IKProjesiAPI.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "SuperAdmin")]
    public class SuperAdminController : ControllerBase
    {
        private readonly ISiteManagerService _siteManagerService;

        public SuperAdminController(ISiteManagerService siteManagerService)
        {
            _siteManagerService = siteManagerService;
        }

        [HttpPost("CreateSiteManager")]
        public async Task<IActionResult> CreateSiteManager([FromBody] CreateSiteManagerDto siteManager)
        {
            await _siteManagerService.Create(siteManager);
            return Ok("KAYIT BAŞARILI");
        }

        [HttpDelete]
        public async Task DeleteSiteManager(int id)
        {
            await _siteManagerService.Delete(id);
        }

    }
}
