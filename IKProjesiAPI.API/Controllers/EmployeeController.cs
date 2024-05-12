using System.Data;
using IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Application.Models.DTOs.ExpenseDTOs;
using IKProjesiAPI.Application.Models.DTOs.OffDayDTOs;
using IKProjesiAPI.Application.Services.EmployeeService;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer", Roles = "EMPLOYEE")]
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

        #region Employee
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
            var updatedEmployee = await _employeeService.UpdateEmployee(model);
            return Ok(updatedEmployee);
        }

        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _employeeService.GetEmployeeById(id);

            return Ok(employee);
        }
        #endregion

        #region Expense
        [HttpPost]
        [Route("CreateExpense")]
        public async Task CreateExpense(CreateExpenseDto createExpense)
        {
            await _employeeService.CreateExpense(createExpense);
        }

        [HttpGet]
        [Route("ListExpense/{id}")]
        public async Task<IActionResult> ListExpense(int id)
        {
            var expense = await _employeeService.ListExpense(id);
            if (expense.Count > 0)
            {
                return Ok(expense);
            }
            else if (expense.Count == 0)
            {
                return BadRequest("Harcama Talebiniz Bulunmamaktadır.");
            }
            else
                return NotFound();
        }
        #endregion

        #region CreateOffDay

        [HttpPost]
        [Route("CreateOffDay")]
        public async Task CreateOffDay([FromBody] CreateOffDayDto model)
        {
            await _employeeService.CreateOffDay(model);
        }

        [HttpGet]
        [Route("ListOffDay/{id}")]
        public async Task<IActionResult> ListOffDay(int id)
        {
            var offDays = await _employeeService.ListOffDay(id);
            return Ok(offDays);
        }
        #endregion

        #region Advance Payment
        [HttpGet]
        [Route("TotalAdvancePayment/{employeeId}")]
        public async Task<IActionResult> TotalAdvancePayment(int employeeId)
        {
            var payment = await _employeeService.TotalAdvancePayment(employeeId);
            return Ok(payment);
        }
        [HttpPost]
        [Route("CreateAdvancePayment")]
        public async Task CreateAdvancePayment([FromBody] CreateAdvancePaymentDto createAdvancePayment)
        {
            await _employeeService.CreateAdvancePayment(createAdvancePayment);
        }

        [HttpGet]
        [Route("ListAdvancePayment/{id}")]
        public async Task<IActionResult> ListAdvancePayment(int id)
        {
            var advance = await _employeeService.ListAdvancePayment(id);
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
        #endregion
    }
}
