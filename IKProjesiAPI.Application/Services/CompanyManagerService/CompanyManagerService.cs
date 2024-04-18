using System;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Domain.Repositories;

namespace IKProjesiAPI.Application.Services.CompanyManagerService
{
    public class CompanyManagerService : ICompanyManagerService
    {

        private readonly ICompanyManagerRepo _companyManagerRepo;

        public CompanyManagerService(ICompanyManagerRepo companyManagerRepo,)
        {

        }
        public async Task Create(CreateCompanyManagerDto model)
        {
            
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateCompanyManagerDto> GetCompanyManagerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ListCompanyManagerDto>> GetCompanyManagers()
        {
            throw new NotImplementedException();
        }

        public Task<List<UpdateCompanyManagerDto>> GetCompanyManagersByCompany(int companyId)
        {
            throw new NotImplementedException();
        }

        public Task Update(UpdateCompanyManagerDto model)
        {
            throw new NotImplementedException();
        }
    }
}

