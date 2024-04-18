using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using IKProjesiAPI.Application.Models.DTOs.UserDTOs;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using IKProjesiAPI.Infrastructure.Context;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using IKProjesiAPI.Application.Services.CompanyManagerService;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyManagerController : ControllerBase
    {
        private readonly ICompanyManagerService _companyManagerService;

        public CompanyManagerController(ICompanyManagerService companyManagerService)
        {
            _companyManagerService = companyManagerService;
        }

        [HttpGet]
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

        [HttpGet("ID")]
        public async Task<IActionResult> GetSpecificCompanyManager(int id)
        {
            var companyManager = await _companyManagerService.GetCompanyManagerById(id);
            if (companyManager != null)
              return Ok(companyManager);
            else
                return NotFound("Şirket Yöneticisi bulunamadı");
        }

        [HttpPost]
        public async Task<IActionResult> AddCompanyManager([FromBody] CompanyManager companyManager)
        {
            var companyManager = await _companyManagerService.Create();
            return Ok(companyManager);



        }

        [HttpDelete("ID")]
        public async Task<IActionResult> DeleteCompanyManager(int id)
        {
             await _companyManagerService.SoftDelete(id);
            return Ok($"{id} numaralı şirket yöneticisi silindi.");

        }

        [HttpGet("ID")]
        public async Task<IActionResult> GetCompanysCompanyManagers([FromBody] int companyId)
        {
            var companyManagers = await _companyManagerService.GetCompanyManagersByCompany(companyId);
            if (companyManagers.Count > 0)
                return Ok(companyManagers);
            else if (companyManagers.Count == 0)
                return BadRequest("Bu şirkete ait Şirket Yöneticisi bulunamadı");
            else
                return NotFound();
        }

        //    [HttpPut("ID")]
        //    

        //    public IActionResult EditCompanyManager([FromBody] CompanyManager companyManager)
        //    {
        //        return Ok(_companyManagerService.Update(companyManager));
        //        //if (_companyManagerService.GetCompanyManagerById(companyManager.Id) != null)
        //        //    return Ok(_companyManagerService.UpdateCompanyManager(companyManager));
        //        //else
        //        //    return NotFound("Şirket Yöneticisi bulunamadı");
        //    }

    }
}
