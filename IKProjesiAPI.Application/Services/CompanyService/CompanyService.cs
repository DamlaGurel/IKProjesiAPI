using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Domain.Repositories;

namespace IKProjesiAPI.Application.Services.CompanyService
{
    public class CompanyService:ICompanyService
    {
        private readonly ICompanyRepo _companyRepo;
        private readonly IMapper _mapper;


        public CompanyService(IMapper mapper, ICompanyRepo companyRepo)
        {
            _mapper = mapper;
            _companyRepo = companyRepo;
        }

        public async Task Add(AddCompanyDto model)
        {
            var company = _mapper.Map<Company>(model);
            await _companyRepo.Create(company);
        }

        public async Task<Company> GetCompany(int id)
        {
            var company = await _companyRepo.GetDefault(x => x.Id == id);
            return company;
        }

        public async Task<CompanyDetailsDto> GetCompanyDetails(int id)
        {
            var company= await _companyRepo.GetFilteredFirstOrDefault(
                select: x => _mapper.Map<CompanyDetailsDto>(x),
                where: x => x.Id.Equals(id) && x.Status != Status.Pasive);
            return company;
        }

        public async Task<List<Company>> GetCompanies()
        {
            var companies = await _companyRepo.GetFilteredList(
                select: x => _mapper.Map<Company>(x),
                where: x => x.Status != Status.Pasive,
                orderBy: x => x.OrderBy(x => x.CompanyName));

            return companies;
        }


        //GetById

        public async Task Delete(int id)
        {
            var deletedCompany = await GetCompany(id);

            if (deletedCompany is not null)
            {
                await _companyRepo.Delete(deletedCompany);
            }
        }

        public async Task SoftDelete(int id)
        {
            var deletedCompany = await GetCompany(id);

            if (deletedCompany is not null)
            {
                deletedCompany.Status = Domain.Enums.Status.Pasive;
                deletedCompany.DeletedDate = DateTime.Now;
                await _companyRepo.Update(deletedCompany);
            }
        }
    }
}
