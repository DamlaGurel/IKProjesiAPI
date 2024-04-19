using IKProjesiAPI.Application.Services.CompanyService;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IKProjesiAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly AppDbContext _context;
        public CompanyController(ICompanyService companyService, AppDbContext context)
        {
            _companyService = companyService;
            _context = context;
        }

        [HttpGet]
        public async Task<List<Company>> Index()
        {
            var companyList = await _companyService.GetCompanies();
            return companyList;
        }
    }
}
