﻿using Microsoft.AspNetCore.Mvc;
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
using IKProjesiAPI.Application.Services.PersonelService;
using System.Net.Mail;
using System.Net;
using IKProjesiAPI.Domain.Entities.AppEntities;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyManagerController : ControllerBase
    {
        private readonly ICompanyManagerService _companyManagerService;
        private readonly IPersonelService _personelService;
        private readonly UserManager<AppUser> _userManager;

        public CompanyManagerController(ICompanyManagerService companyManagerService, IPersonelService personelService, UserManager<AppUser> userManager)
        {
            _companyManagerService = companyManagerService;
            _personelService = personelService;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("GetCompanyManagerSummary/{id}")]
        public async Task<IActionResult> GetCompanyManagerSummary(int id)
        {
            var companyManagerSummary = await _companyManagerService.GetCompanyManagerSummary(id);

            if (companyManagerSummary != null)
                return Ok(companyManagerSummary);
            else
                return NotFound("kullanıcı bulunamadı");
        }


        [HttpGet]
        [Route("GetCompanyManagerDetails/{id}")]
        public async Task<IActionResult> GetCompanyManagerDetails(int id)
        {
            var companyManagerDetails = await _companyManagerService.GetCompanyManagerDetails(id);

            if (companyManagerDetails != null)
                return Ok(companyManagerDetails);
            else
                return NotFound("kullanıcı bulunamadı");
        }

        [HttpPut]
        [Route("GetCompanyManagerUpdate")]
        public async Task<IActionResult> GetCompanyManagerUpdate([FromBody] UpdateCompanyManagerDto model)
        {
            await _companyManagerService.Update(model);
            return Ok();
        }

        [HttpPost]
        [Route("AddPersonel")]
        public async Task<IActionResult> AddPersonel([FromBody] CreatePersonelDto model)
        {
            //if (!User.IsInRole(Job.CompanyManager.ToString().ToUpper()))
            //{
            //    return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            //}

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var personel = await _personelService.CreatePersonel(model);
            var p = await _userManager.FindByNameAsync(personel.Username.ToUpper());
            p.SecurityStamp = Guid.NewGuid().ToString();
            if (p != null)
            {
                string roleName = Job.Personel.ToString().ToUpper();
                await _userManager.AddToRoleAsync(p, roleName);
            }

            MailMessage message = new MailMessage();
            message.From = new MailAddress("mailadresi@mail.com");
            message.To.Add(new MailAddress(p.Email));
            message.IsBodyHtml = true;
            message.Subject = "Hoşgeldiniz";
            message.Body = "Şirketimize hoşgeldiniz";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("arslanilkay06@gmail.com", "xbishuykxbcmashq");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(message);

            return Ok("Kayıt Başarılı. Mail Gönderilmiştir.");
        }
    }
}
