using IKProjesiAPI.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using IKProjesiAPI.Application.Models.DTOs.UserDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly UserManager<AppUser> _userManager;
        public MailController(AppDbContext context, IConfiguration configuration, UserManager<AppUser> userManager)
        {
            _context = context;
            _configuration = configuration;
            _userManager = userManager;
        }
        [HttpPost]
        [Route("SendMail/{email}")]
        public async Task<IActionResult> SendMail(string email)
        {
            var user = await _context.AppUsers.FirstOrDefaultAsync(u => u.Email == email);

            //var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                Guid newGuid = Guid.NewGuid();
                string guidString = newGuid.ToString();



                MailMessage message = new MailMessage();
                message.From = new MailAddress("mailadresi@mail.com");
                message.To.Add(new MailAddress(email));
                message.IsBodyHtml = true;
                message.Subject = "Geçiçi Şifreniz";
                message.Body = guidString;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("arslanilkay06@gmail.com", "xbishuykxbcmashq");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(message);

                //user.Password = guidString;
                //await _context.SaveChangesAsync();
                //var temporaryPassword = new TemporaryPassword
                //{
                //    OldPassword = user.Password,
                //    NewPassword = guidString,
                //    UserId = user.Id
                //};

                //_context.TemporaryPassword.Add(temporaryPassword);
                await _context.SaveChangesAsync();
                return Ok(user.Password);
            }
            else
            {
                return NotFound("Belirtilen e-postaya sahip bir kullanıcı bulunamadı.");
            }
        }
    }
}
