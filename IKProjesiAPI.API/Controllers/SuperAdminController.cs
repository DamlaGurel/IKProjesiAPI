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
        public IActionResult CreateSiteManager([FromBody] CreateSiteManagerDto siteManager)
        {
            return Ok(_siteManagerService.Create(siteManager));
        }

        //[HttpPut]
        //public IActionResult UpdateSiteManager(SiteManagerUpdateDto siteManager)
        //{
        //    return Ok(_siteManagerService.Update(siteManager));
        //}

        [HttpDelete]
        public void DeleteSiteManager(int id)
        {
            _siteManagerService.Delete(id);
        }

    }
}
