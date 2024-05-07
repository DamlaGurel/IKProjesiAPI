using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using IKProjesiAPI.Application.Services.CompanyManagerService;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Domain.Enums;
using System.Net.Mail;
using System.Net;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Application.Services.EmployeeService;
using IKProjesiAPI.Domain.Entities;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyManagerController : ControllerBase
    {
        private readonly ICompanyManagerService _companyManagerService;
        private readonly IEmployeeService _employeeService;
        private readonly UserManager<AppUser> _userManager;



        public CompanyManagerController(ICompanyManagerService companyManagerService, IEmployeeService employeeService, UserManager<AppUser> userManager)
        {
            _companyManagerService = companyManagerService;
            _employeeService = employeeService;
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

        [HttpGet]
        [Route("GetCompanyManagerById/{id}")]
        public async Task<IActionResult> GetCompanyManagerById(int id)
        {
            var companyManager = await _companyManagerService.GetCompanyManagerById(id);

            return Ok(companyManager);
        }

        [HttpPut]
        [Route("GetCompanyManagerUpdate")]
        public async Task<IActionResult> GetCompanyManagerUpdate([FromBody] UpdateCompanyManagerDto model)
        {
            await _companyManagerService.Update(model);
            return Ok();
        }

        [HttpPost]
        [Route("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeDto model)
        {
            //if (!User.IsInRole(Job.CompanyManager.ToString().ToUpper()))
            //{
            //    return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            //}

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employee = await _employeeService.CreateEmployee(model);
            var p = await _userManager.FindByNameAsync(employee.UserName.ToUpper());

            p.SecurityStamp = Guid.NewGuid().ToString();
            if (p != null)
            {
                string roleName = Job.Employee.ToString().ToUpper();
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

        [HttpGet]
        [Route("ListApprovalForOffDay")]
        public async Task<IActionResult> ListApprovalForOffDay()
        {
           var listofApprovalForOffDay = await _companyManagerService.WaitingApprovalForDayOff();
            return Ok(listofApprovalForOffDay);
        }

        [HttpPut]
        [Route("UpdateApprovalForOffDay")]
        public async Task<IActionResult> UpdateApprovalForOffDay([FromBody] UpdateDayOffDto model)
        {
           await _employeeService.UpdateTakeDayOff(model);
            return Ok();
        }


        [HttpGet]
        [Route("GetApprovalForOffDay/{id}")]
        public async Task<IActionResult> GetApprovalForOffDay(int id)
        {
           var offDay= await _employeeService.GetTakeDayOff(id);
            return Ok(offDay);
        }

        [HttpGet]
        [Route("ListApprovalForExpense")]
        public async Task<IActionResult> ListApprovalForExpense()
        {
            var listApprovalForExpense = await _companyManagerService.WaitingApprovalForExpense();
            return Ok(listApprovalForExpense);
        }
        //[HttpPut]
        //[Route("UpdateApprovalForExpense")]
        //public async Task<IActionResult> UpdateApprovalForExpense([FromBody] UpdateExpenseDto model)
        //{
        //    await _employeeService.UpdateExpense(model);
        //    return Ok();
        //}


        //[HttpGet]
        //[Route("GetApprovalForExpense/{id}")]
        //public async Task<IActionResult> GetApprovalForExpense(int id)
        //{
        //    var expense = await _employeeService.GetExpense(id);
        //    return Ok(expense);
        //}
        //[HttpGet]
        //[Route("ListApprovalForAdvancePayment")]
        //public async Task<IActionResult> ListApprovalForAdvancePayment()
        //{
        //    var listApprovalForAdvancePayment = await _companyManagerService.WaitingApprovalForAdvance();
        //    return Ok(listApprovalForAdvancePayment);
        //}

        //[HttpPut]
        //[Route("UpdateApprovalForAdvance")]
        //public async Task<IActionResult> UpdateApprovalForAdvance([FromBody] UpdateAdvanceDto model)
        //{
        //    await _employeeService.UpdateAdvance(model);
        //    return Ok();
        //}


        //[HttpGet]
        //[Route("GetApprovalForAdvance/{id}")]
        //public async Task<IActionResult> GetApprovalForAdvance(int id)
        //{
        //    var advance = await _employeeService.GetAdvance(id);
        //    return Ok(advance);
        //}
    }
}
