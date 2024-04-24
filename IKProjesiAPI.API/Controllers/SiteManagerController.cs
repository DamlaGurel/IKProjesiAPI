using IKProjesiAPI.Application.Models.DTOs.CompanyDTOs;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;

using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;

using IKProjesiAPI.Application.Services.CompanyManagerService;
using IKProjesiAPI.Application.Services.CompanyService;
using IKProjesiAPI.Application.Services.SiteManagerService;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    //[Authorize(AuthenticationSchemes = "Bearer",Roles = "SiteManager")]

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

        // CompanyManager

        [HttpPost]
        [Route("AddCompanyManager")]
        public async Task<IActionResult> AddCompanyManager([FromBody] CreateCompanyManagerDto createCompanyManager)
        {
            //if (!User.IsInRole(Job.SiteManager.ToString().ToUpper()))
            //{
            //    return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            //}

            //if (!User.IsInRole("SiteManager"))
            //{
            //    return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            //}

            await _companyManagerService.Create(createCompanyManager);
            return Ok($"{createCompanyManager.IdentityNumber} TC Kimlik numaralı Şirket Yöneticisi oluşturuldu.");

        }


        // SiteManager

        [HttpGet]
        [Route("SiteManagerSummary")]
        public async Task<IActionResult> SiteManagerSummary(int id)
        {
            var siteManagerSummary = await _siteManagerService.GetSiteManagerSummary(id);

            if (siteManagerSummary != null)
                return Ok(siteManagerSummary);
            else
                return NotFound("kullanıcı bulunamadı");
        }

        [HttpGet]
        [Route("SiteManagerDetails")]
        public async Task<IActionResult> SiteManagerDetails(int id)
        {
            var siteManagerDetails = await _siteManagerService.GetSiteManagerDetails(id);

            if (siteManagerDetails != null)
                return Ok(siteManagerDetails);
            else
                return NotFound("kullanıcı bulunamadı");
        }

        [HttpPut]
        [Route("UpdateSiteManager")]
        public async Task<IActionResult> UpdateSiteManager([FromBody] SiteManagerUpdateDto siteManager)
        {
            //if (!User.IsInRole("SiteManager"))
            //{
            //    return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            //}

            await _siteManagerService.Update(siteManager);
            return Ok("KAYIT GÜNCELLENDİ");
        }


        // Company

        [HttpGet]
        [Route("CompanyIndex")]
        public async Task<List<CompanyListDto>> CompanyIndex()
        {
            var companyList = await _companyService.GetCompanies();
            return companyList;
        }


        [HttpPost]
        [Route("CreateCompany")]
        public async Task<IActionResult> CreateCompany([FromBody] CreateCompanyDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _companyService.Create(model);
            return Ok();
        }


        [HttpGet]
        [Route("CompanyDetails/{id}")]
        public async Task<IActionResult> CompanyDetails(int id)

        {
            var companyDetails = await _companyService.GetCompanyDetails(id);

            if (companyDetails == null)
            {
                return NotFound("Company bulunamadı.");
            }

            return Ok(companyDetails);
        }

        [HttpDelete]
        [Route("DeleteCompany")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            await _companyService.SoftDelete(id);
            return Ok();
        }

        [HttpGet]
        [Route("GetAllCompanyManagers")]
        public async Task<IActionResult> GetAllCompanyManagers()
        {
            var companyManagers = await _companyManagerService.GetCompanyManagers();
            if (companyManagers.Count > 0)
                return Ok(companyManagers);
            else if (companyManagers.Count == 0)
                return BadRequest("Şirket Yöneticisi bulunamadı");
            else
                return NotFound();
        }
    }
}
