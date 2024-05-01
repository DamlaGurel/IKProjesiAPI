using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Services.PersonelService
{
    public interface IEmployeeService
    {
        Task<CreateEmployeeDto> CreateEmployee(CreateEmployeeDto model);
    }
}
