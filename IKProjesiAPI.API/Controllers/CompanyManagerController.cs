using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using IKProjesiAPI.Application.Models.DTOs.UserDTOs;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using IKProjesiAPI.Application.Services.CompanyManagerService;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using AutoMapper;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyManagerController : ControllerBase
    {
        private readonly ICompanyManagerService _companyManagerService;
       

        public CompanyManagerController(ICompanyManagerService companyManagerService)
        {
            _companyManagerService = companyManagerService;
            
        }


        //    [HttpGet("ID")]
        //   public async Task<IActionResult> GetSpecificCompanyManager(int id)
        //   {
        //   var companyManager = await _companyManagerService.GetCompanyManagerById(id);
        //      if (companyManager != null)
        //       return Ok(companyManager);
        //     else
        //        return NotFound("Şirket Yöneticisi bulunamadı");
        //  }


        [HttpPost]
    [Route("AddCompanyManager")]

        public async Task<IActionResult> AddCompanyManager([FromBody] CreateCompanyManagerDto createCompanyManager)
        {
            await _companyManagerService.Create(createCompanyManager);
            return Ok($"{createCompanyManager.IdentityNumber} TC Kimlik numaralı Şirket Yöneticisi oluşturuldu.");
        }


        //  [HttpDelete("ID")]
        //  public async Task<IActionResult> DeleteCompanyManager(int id)
        //  {
        //   await _companyManagerService.SoftDelete(id);
        //      return Ok($"{id} numaralı şirket yöneticisi silindi.");

        // }

      

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
