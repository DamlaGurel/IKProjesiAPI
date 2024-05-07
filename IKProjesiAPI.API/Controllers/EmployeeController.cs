using IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Application.Models.DTOs.ExpenseDTOs;
using IKProjesiAPI.Application.Models.DTOs.OffDayDTOs;
using IKProjesiAPI.Application.Services.EmployeeService;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly UserManager<AppUser> _userManager;
        public EmployeeController(IEmployeeService employeeService, UserManager<AppUser> userManager)
        {
            _employeeService = employeeService;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //Employee İşlemleri
        [HttpGet]
        [Route("GetEmployeeSummary/{id}")]
        public async Task<IActionResult> GetEmployeeSummary(int id)
        {
            var employeeSummary = await _employeeService.GetEmployeeSummary(id);

            if (employeeSummary != null)
                return Ok(employeeSummary);
            else
                return NotFound("Employee bulunamadı");
        }

        [HttpGet]
        [Route("GetEmployeeDetails/{id}")]
        public async Task<IActionResult> GetEmployeeDetails(int id)
        {
            var employeeDetails = await _employeeService.GetEmployeeDetails(id);

            if (employeeDetails != null)
                return Ok(employeeDetails);
            else
                return NotFound("Employee bulunamadı");
        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeDto model)
        {
            await _employeeService.UpdateEmployee(model);
            return Ok();
        }

        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _employeeService.GetEmployeeById(id);

            return Ok(employee);
        }

        //Expense İşlemleri
        [HttpPost]
        [Route("CreateExpense")]
        public async Task CreateExpense(CreateExpenseDto createExpense)
        {
            await _employeeService.CreateExpense(createExpense);
        }

        //OffDay İşlemleri

        [HttpPost]
        [Route("CreateTakeDayOff")]
        public async Task CreateTakeDayOff([FromBody] CreateTakeDayOffDto model)
        {
            await _employeeService.CreateTakeDayOff(model);
        }

        [HttpGet]
        [Route("ListTakeDayOff/{id}")]
        public async Task<IActionResult> ListTakeDayOff(int id)
        {
            var offDays = await _employeeService.ListTakeDayOff(id);
            

            return Ok(offDays);

        }

       //Advance Payment İşlemleri

        [HttpPost]
        [Route("CreateAdvancePayment")]
        public async Task CreateAdvancePayment([FromBody] CreateAdvancePaymentDto createAdvancePayment)
        {
            await _employeeService.CreateAdvancePayment(createAdvancePayment);
        }

        [HttpGet]
        [Route("ListAdvancePayment")]
        public async Task<IActionResult> ListAdvancePayment()
        {
            var advance = await _employeeService.ListAdvancePayments();
            if (advance.Count > 0)
            {
                return Ok(advance);
            }
            else if (advance.Count == 0)
            {
                return BadRequest("Avans Talebiniz Bulunmamaktadır.");
            }
            else
                return NotFound();
        }

    }
}
