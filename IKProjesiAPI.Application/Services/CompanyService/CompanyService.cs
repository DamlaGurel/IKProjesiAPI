using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.Services.CompanyService
{
    public class CompanyService:ICompanyService
    {
        private readonly ICompanyService _companyService;
        private readonly ICompanyRepo _companyRepo;
        private readonly IMapper _mapper;


        public CompanyService(ICompanyService companyService, IMapper mapper, ICompanyRepo companyRepo)
        {
            _companyService = companyService;
            _mapper = mapper;
            _companyRepo = companyRepo;
        }

        public async Task Add(AddCompanyDto model)
        {
            var company = _mapper.Map<Company>(model);
            await _companyRepo.Create(company);
        }
    }
}
