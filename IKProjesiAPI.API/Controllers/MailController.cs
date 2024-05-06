using IKProjesiAPI.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
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

            if (user != null)
            {
                Guid newGuid = Guid.NewGuid();
                string guidString = newGuid.ToString();

                string jsonPassword = guidString.Replace("-", "");

                MailMessage message = new MailMessage();
                message.From = new MailAddress("mailadresi@mail.com");
                message.To.Add(new MailAddress(email));
                message.IsBodyHtml = true;
                message.Subject = "Geçiçi Şifreniz";
                message.Body = jsonPassword;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("arslanilkay06@gmail.com", "xbishuykxbcmashq");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(message);

                user.TemporaryPassword = jsonPassword;
                await _context.SaveChangesAsync();
                return Ok(user.TemporaryPassword);
            }
            else
            {
                return Ok(user);
                //return BadRequest("Belirtilen e-postaya sahip bir kullanıcı bulunamadı.");
            }
        }
    }
}
