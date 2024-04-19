using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Application.Services.CompanyManagerService;
using IKProjesiAPI.Application.Services.CompanyService;
using IKProjesiAPI.Application.Services.SiteManagerService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize(Roles = "SiteManager")]
    public class SiteManagerController : Controller
    {
        private readonly ISiteManagerService _siteManagerService;
        private readonly ICompanyManagerService _companyManagerService;
        private readonly ICompanyService _companyService;

        public SiteManagerController(ISiteManagerService siteManagerService, ICompanyManagerService companyManagerService, ICompanyService companyService)
        {
            _siteManagerService = siteManagerService;
            _companyManagerService = companyManagerService;
            _companyService = companyService;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSiteManager([FromBody] SiteManagerUpdateDto siteManager)
        {
            await _siteManagerService.Update(siteManager);
            return Ok("KAYIT GÜNCELLENDİ");
        }

    }
}
