﻿using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;

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
    //[Authorize(AuthenticationSchemes = "Bearer")]
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

        

        [HttpPost]
        [Route("AddCompanyManager")]
        public async Task<IActionResult> AddCompanyManager([FromBody] CreateCompanyManagerDto createCompanyManager)
        {

            //if (!User.IsInRole("SiteManager"))
            //{
            //    return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            //}

            await _companyManagerService.Create(createCompanyManager);
            return Ok($"{createCompanyManager.IdentityNumber} TC Kimlik numaralı Şirket Yöneticisi oluşturuldu.");

        }

        [HttpPut]
        public async Task<IActionResult> UpdateSiteManager([FromBody] SiteManagerUpdateDto siteManager)
        {
            await _siteManagerService.Update(siteManager);
            return Ok("KAYIT GÜNCELLENDİ");
        }

            //[HttpGet]
        // public async Task<IActionResult> GetAllCompanyManagers()
        // {
        //   var companyManagers = await _companyManagerService.GetCompanyManagers();
        //   if (companyManagers.Count > 0)
        //       return Ok(companyManagers);
        //  else if (companyManagers.Count == 0)
        //      return BadRequest("Şirket Yöneticisi bulunamadı");
        //   else
        //     return NotFound();
        //  }


        //  [HttpGet("ID")]
        //  public async Task<IActionResult> GetCompanysCompanyManagers([FromBody] int companyId)
        // {
        // var companyManagers = await _companyManagerService.GetCompanyManagersByCompany(companyId);
        //     if (companyManagers.Count > 0)
        //        return Ok(companyManagers);
        //    else if (companyManagers.Count == 0)
        //       return BadRequest("Bu şirkete ait Şirket Yöneticisi bulunamadı");
        //   else
        //         return NotFound();
        // }

    }
}
