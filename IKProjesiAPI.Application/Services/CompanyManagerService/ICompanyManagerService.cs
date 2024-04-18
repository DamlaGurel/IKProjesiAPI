using System;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;

namespace IKProjesiAPI.Application.Services.CompanyManagerService
{
	public interface ICompanyManagerService
	{
        Task Create(CreateCompanyManagerDto model);
    }
}

