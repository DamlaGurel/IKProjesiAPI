using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace IKProjesiAPI.UI.Controllers
{
    public class MailController : Controller
    {
        public AppDbContext _context;
        public MailController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult GeciciSifre()
        {
            Guid newGuid = Guid.NewGuid();
            string guidString = newGuid.ToString();

            var temporaryPassword = new TemporaryPassword
            {
                Password = guidString
            };

            _context.TemporaryPasswords.Add(temporaryPassword);
            _context.SaveChanges();

            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("arslanilkay06@gmail.com", "xbishuykxbcmashq");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("arslanilkay06@gmail.com");
                mail.To.Add(new MailAddress("arslanilkay06@gmail.com"));
                mail.Subject = "New GUID";
                mail.Body = guidString;

                smtp.Send(mail);

                ViewBag.Message = "E-posta başarıyla gönderildi.";
            }
            catch (Exception ex)
            {
                ViewBag.Message = "E-posta gönderilirken bir hata oluştu: " + ex.Message;
            }
            return null;
        }
    }
}
