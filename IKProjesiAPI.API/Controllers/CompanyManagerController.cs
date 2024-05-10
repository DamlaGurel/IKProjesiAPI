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
using IKProjesiAPI.Application.Models.DTOs.OffDayDTOs;
using IKProjesiAPI.Application.Models.DTOs.ExpenseDTOs;
using IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer", Roles = "COMPANYMANAGER")]
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

        #region Company Manager
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
        #endregion

        #region Employee
        [HttpPost]
        [Route("CreateEmployee")]
        public async Task<CreateEmployeeDto> CreateEmployee([FromBody] CreateEmployeeDto model)
        {
            //if (!User.IsInRole(Job.CompanyManager.ToString().ToUpper()))
            //{
            //    return StatusCode(403, "Yetkisiz erişim: Bu işlemi gerçekleştirmek için yeterli izniniz yok.");
            //}

            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            var employee = await _employeeService.CreateEmployee(model);
            var p = await _userManager.FindByNameAsync(employee.UserName.ToUpper());

            p.SecurityStamp = Guid.NewGuid().ToString();
            if (p != null)
            {
                string roleName = Job.Employee.ToString().ToUpper();
                await _userManager.AddToRoleAsync(p, roleName);
            }

            //MailMessage message = new MailMessage();
            //message.From = new MailAddress("mailadresi@mail.com");
            //message.To.Add(new MailAddress(p.Email));
            //message.IsBodyHtml = true;
            //message.Subject = "Hoşgeldiniz";
            //message.Body = "Şirketimize hoşgeldiniz";

            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = "smtp.gmail.com";
            //smtp.Port = 587;
            //smtp.EnableSsl = true;
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new NetworkCredential("arslanilkay06@gmail.com", "xbishuykxbcmashq");
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            //smtp.Send(message);

            //return Ok("Kayıt Başarılı. Mail Gönderilmiştir.");
            return employee;
        }
        #endregion

        #region Off Day
        [HttpGet]
        [Route("ListApprovalForOffDay")]
        public async Task<IActionResult> ListApprovalForOffDay()
        {
           var listofApprovalForOffDay = await _companyManagerService.WaitingApprovalForOffDay();
            return Ok(listofApprovalForOffDay);
        }

        [HttpPut]
        [Route("UpdateApprovalForOffDay")]
        public async Task<IActionResult> UpdateApprovalForOffDay([FromBody] UpdateOffDayDto model)
        {
           await _employeeService.UpdateOffDay(model);
            return Ok();
        }


        [HttpGet]
        [Route("GetApprovalForOffDay/{id}")]
        public async Task<IActionResult> GetApprovalForOffDay(int id)
        {
           var offDay= await _employeeService.GetOffDay(id);
            return Ok(offDay);
        }
        #endregion

        #region Expense
        [HttpGet]
        [Route("ListApprovalForExpense")]
        public async Task<IActionResult> ListApprovalForExpense()
        {
            var listApprovalForExpense = await _companyManagerService.WaitingApprovalForExpense();
            return Ok(listApprovalForExpense);
        }

        [HttpPut]
        [Route("UpdateApprovalForExpense")]
        public async Task<IActionResult> UpdateApprovalForExpense([FromBody] UpdateExpenseDto model)
        {
            await _employeeService.UpdateExpense(model);
            return Ok();
        }

        [HttpGet]
        [Route("GetApprovalForExpense/{id}")]
        public async Task<IActionResult> GetApprovalForExpense(int id)
        {
            var expense = await _employeeService.GetExpense(id);
            return Ok(expense);
        }
        #endregion

        #region Advance Payment
        [HttpGet]
        [Route("ListApprovalForAdvancePayment")]
        public async Task<IActionResult> ListApprovalForAdvancePayment()
        {
            var listApprovalForAdvancePayment = await _companyManagerService.WaitingApprovalForAdvancePayment();
            return Ok(listApprovalForAdvancePayment);
        }

        [HttpPut]
        [Route("UpdateApprovalForAdvancePayment")]
        public async Task<IActionResult> UpdateApprovalForAdvancePayment([FromBody] UpdateAdvancePaymentDto model)
        {
            await _employeeService.UpdateAdvancePayment(model);
            return Ok();
        }


        [HttpGet]
        [Route("GetApprovalForAdvance/{id}")]
        public async Task<IActionResult> GetApprovalForAdvancePayment(int id)
        {
            var advance = await _employeeService.GetAdvancePayment(id);
            return Ok(advance);
        }
        #endregion 
    }
}
