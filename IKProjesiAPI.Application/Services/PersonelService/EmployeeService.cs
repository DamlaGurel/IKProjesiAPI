using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Services.PersonelService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepo employeeRepo, IMapper mapper)
        {
            _employeeRepo = employeeRepo;
            _mapper = mapper;
        }
                
        public async Task<CreateEmployeeDto> CreateEmployee(CreateEmployeeDto model)
        {
            var employee = _mapper.Map<Employee>(model);
            employee.Email=$"{employee.FirstName}.{employee.LastName}@bilgeadamboost.com";
            employee.UserName = employee.Email;
            employee.NormalizedUserName = employee.Email.ToUpper();
            employee.JobName = Domain.Enums.Job.Employee;
            await _employeeRepo.Create(employee);

            var p = _mapper.Map<CreateEmployeeDto>(employee);
            return p;
        }


        // Expence işlemleri 





    }
}
