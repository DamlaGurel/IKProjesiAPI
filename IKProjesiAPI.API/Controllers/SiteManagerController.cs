﻿using IKProjesiAPI.Application.Models.DTOs.CompanyDTOs;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
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
    [Authorize(AuthenticationSchemes = "Bearer")]
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
            if (!User.IsInRole("SiteManager"))
            {
                return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            }

            await _companyManagerService.Create(createCompanyManager);
            return Ok($"{createCompanyManager.IdentityNumber} TC Kimlik numaralı Şirket Yöneticisi oluşturuldu.");

        }


        // SiteManager
        [HttpPut]
        public async Task<IActionResult> UpdateSiteManager([FromBody] SiteManagerUpdateDto siteManager)
        {
            if (!User.IsInRole("SiteManager"))
            {
                return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            }

            await _siteManagerService.Update(siteManager);
            return Ok("KAYIT GÜNCELLENDİ");
        }


        // Company

        [HttpGet]
        [Route("Index")]
        public async Task<List<CompanyListDto>> Index()
        {
            var companyList = await _companyService.GetCompanies();
            return companyList;
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return Ok();
        }
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] CreateCompanyDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _companyService.Create(model);
            return Ok();
        }

        [HttpGet]
        [Route("Detail")]
        public async Task<IActionResult> Detail(int id)
        {
            var companyDetails = await _companyService.GetCompanyDetails(id);

            if (companyDetails == null)
            {
                return NotFound("Company bulunamadı.");
            }

            return Ok(companyDetails);
        }
        [HttpGet]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _companyService.SoftDelete(id);
            return Ok();
        }


    }
}
