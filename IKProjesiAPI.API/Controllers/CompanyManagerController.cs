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

        [HttpPost]
        [Route("CreatePersoneş")]
        public async Task<IActionResult> CreatePersonel([FromBody]CreatePersonelDto model)
        {
            //if (!User.IsInRole(Job.CompanyManager.ToString().ToUpper()))
            //{
            //    return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            //}
            await _companyManagerService.CreatePersonel(model);

            //var user = await _userManager.FindByNameAsync(createCompanyManager.UserName.ToUpper());

            //user.SecurityStamp = Guid.NewGuid().ToString();
            //if (user != null)
            //{
            //    string roleName = Job.CompanyManager.ToString().ToUpper();
            //    await _roleManager.RoleExistsAsync(roleName.ToUpper());
            //    await _userManager.AddToRoleAsync(user, roleName);
            //}

            //try
            //{
            //    await _companyManagerService.Create(createCompanyManager);
            //    return Ok(createCompanyManager);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Hata oluştu: {ex.Message}");
            //    return StatusCode(500, "Bir hata oluştu, Şirket Yöneticisi eklenemedi.");
            //}
            return Ok();
        }
       

    }
}
