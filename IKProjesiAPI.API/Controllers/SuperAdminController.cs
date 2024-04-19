using IKProjesiAPI.Application.Services.SiteManagerService;
using IKProjesiAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperAdminController : ControllerBase
    {
        private readonly ISiteManagerService _siteManagerService;

        public SuperAdminController(ISiteManagerService siteManagerService)
        {
            _siteManagerService = siteManagerService;
        }

        //[HttpPost]
        //public IActionResult AddSiteManager(SiteManager siteManager)
        //{
        //    return Ok(_siteManagerService.Add(siteManager));
        //}
    }
}
