﻿using IKProjesiAPI.Application.Models.DTOs.CompanyDTOs;
using IKProjesiAPI.Domain.Entities;

namespace IKProjesiAPI.Application.Services.CompanyService
{
    public interface ICompanyService
    {
        Task Create(CreateCompanyDto model);
        Task<Company> GetCompany(int id);
        Task<CompanyDetailsDto> GetCompanyDetails(int id);
        Task<List<CompanyListDto>> GetCompanies();
        Task Delete(int id);
        Task SoftDelete(int id);
    }
}
