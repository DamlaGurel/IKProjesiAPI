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
using IKProjesiAPI.Domain.Enums;

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

        [HttpGet]
        [Route("CompanyManagerSummary/{id}")]
        public async Task<IActionResult> GetCompanyManagerSummary(int id)
        {
            var companyManagerSummary = await _companyManagerService.GetCompanyManagerSummary(id);

            if (companyManagerSummary != null)
                return Ok(companyManagerSummary);
            else
                return NotFound("kullanıcı bulunamadı");
        }


        [HttpGet]
        [Route("CompanyManagerDetails/{id}")]
        public async Task<IActionResult> GetCompanyManagerDetails(int id)
        {
            var companyManagerDetails = await _companyManagerService.GetCompanyManagerDetails(id);

            if (companyManagerDetails != null)
                return Ok(companyManagerDetails);
            else
                return NotFound("kullanıcı bulunamadı");
        }

        [HttpPut]
        [Route("CompanyManagerUpdate")]
        public async Task<IActionResult> GetCompanyManagerUpdate([FromBody] UpdateCompanyManagerDto model)
        {
            await _companyManagerService.Update(model);
            return Ok();
        }

    }
}
