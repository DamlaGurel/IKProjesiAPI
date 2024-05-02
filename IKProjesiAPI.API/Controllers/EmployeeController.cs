using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Application.Services.EmployeeService;
using IKProjesiAPI.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

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

        [HttpPost]
        [Route("CreateExpense")]
        public async Task CreateExpense([FromBody] CreateExpenseDto createExpense)
        {
            await _employeeService.CreateExpense(createExpense);
        }

    }
}
