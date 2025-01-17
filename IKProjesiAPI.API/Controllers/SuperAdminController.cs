﻿using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Application.Services.SiteManagerService;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer", Roles = "SUPERADMIN")]

    public class SuperAdminController : ControllerBase
    {
        private readonly ISiteManagerService _siteManagerService;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public SuperAdminController(ISiteManagerService siteManagerService, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _siteManagerService = siteManagerService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost]
        [Route("CreateSiteManager")]
        public async Task<IActionResult> CreateSiteManager([FromBody] CreateSiteManagerDto siteManager)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sm = await _siteManagerService.CreateSiteManager(siteManager);
            var user = await _userManager.FindByNameAsync(sm.UserName.ToUpper());
            user.SecurityStamp = Guid.NewGuid().ToString();

            if (user != null)
            {
                string roleName = Job.SITEMANAGER.ToString().ToUpper();
                await _userManager.AddToRoleAsync(user, roleName);
            }

            return Ok("KAYIT BAŞARILI");
        }

        [HttpDelete("DeleteSiteManager")]
        public async Task<IActionResult> DeleteSiteManager(int id)
        {
            await _siteManagerService.DeleteSiteManager(id);
            return Ok("SİLME BAŞARILI");
        }

        [HttpGet]
        [Route("SiteManagerDetail")]
        public async Task<IActionResult> SiteManagerDetail()
        {
            var siteManager = await _siteManagerService.SiteManagerDetails();
            return Ok(siteManager);
        }

        [HttpGet]
        [Route("Deneme")]
        public async Task<IActionResult> Deneme()
        {
            return Ok();
        }

    }
}
