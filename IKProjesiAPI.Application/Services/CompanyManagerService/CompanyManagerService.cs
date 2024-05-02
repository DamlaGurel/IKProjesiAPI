using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace IKProjesiAPI.Application.Services.CompanyManagerService
{
    public class CompanyManagerService : ICompanyManagerService
    {

        private readonly ICompanyManagerRepo _companyManagerRepo;
        private readonly ICompanyRepo _companyRepo;
        private readonly IMapper _mapper;


        public CompanyManagerService(ICompanyManagerRepo companyManagerRepo, ICompanyRepo companyRepo, IMapper mapper)
        {
            _companyRepo = companyRepo;
            _companyManagerRepo = companyManagerRepo;
            _mapper = mapper;
        }

        public async Task<CreateCompanyManagerDto> Create(CreateCompanyManagerDto model)
        {
            var companyManager = _mapper.Map<CompanyManager>(model);

            companyManager.Email = $"{model.FirstName}.{model.LastName}@bilgeadamboost.com";
            companyManager.UserName = companyManager.Email;
            companyManager.NormalizedUserName = companyManager.Email.ToUpper();
            companyManager.Password = $"{model.FirstName}.{model.LastName}";

            Company company = await _companyRepo.GetDefault(c => c.Id == model.CompanyId);
            companyManager.Company = company;
            companyManager.JobName = Job.CompanyManager;
            companyManager.ImageBytes = Convert.FromBase64String(model.ImageString);
            companyManager.CreatedDate = DateTime.Now;
            companyManager.Status = Status.Active;

            await _companyManagerRepo.Create(companyManager);
            return _mapper.Map<CreateCompanyManagerDto>(companyManager);
        }

        public async Task Delete(int id)
        {
            var companyManager = await _companyManagerRepo.GetDefault(x => x.Id.Equals(id));
            await _companyManagerRepo.Delete(companyManager);
        }

        public async Task<UpdateCompanyManagerDto> GetCompanyManagerById(int id)
        {
            var companyManager = await _companyManagerRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<UpdateCompanyManagerDto>(x),
                                                                                     where: x => x.Id == id);
            return companyManager;
        }

        public async Task<List<ListCompanyManagerDto>> GetCompanyManagers()
        {
            var companyManager = await _companyManagerRepo.GetFilteredList(select: x => new ListCompanyManagerDto
                                                                                        {
                                                                                            FirstName = x.FirstName,
                                                                                            SecondName = x.SecondName,
                                                                                            LastName = x.LastName,
                                                                                            SecondLastName = x.SecondLastName,
                                                                                            Email = x.Email,
                                                                                            PhoneNumber = x.PhoneNumber,
                                                                                            CompanyId = x.CompanyId,
                                                                                            CompanyName = x.Company.CompanyName,
                                                                                        },
                                                                           where: x => !x.Status.Equals(Status.Pasive),
                                                                           orderBy: x => x.OrderBy(x => x.CompanyId),
                                                                           include: query => query.Include(x => x.Company));

            return companyManager;
        }

        public async Task<List<ListCompanyManagerDto>> GetCompanyManagersByCompany(int companyId)
        {
            var companyManager = await _companyManagerRepo.GetFilteredList(select: x => _mapper.Map<ListCompanyManagerDto>(x),
                                                                           where: x => x.CompanyId.Equals(companyId),
                                                                           orderBy: x => x.OrderBy(x => x.Id));
            return companyManager;
        }

        public async Task<SummaryCompanyManagerDto> GetCompanyManagerSummary(int id)
        {
            var companyManager = await _companyManagerRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<SummaryCompanyManagerDto>(x),
                                                                                     where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

            string imageString = null;

            if (companyManager != null && companyManager.ImageBytes != null)
                imageString = Convert.ToBase64String(companyManager.ImageBytes);
            companyManager.ImageString = imageString;

            return companyManager;
        }

        public async Task<DetailCompanyManagerDto> GetCompanyManagerDetails(int id)
        {
            var companyManager = await _companyManagerRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<DetailCompanyManagerDto>(x),
                                                                                     where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

            string imageString = null;

            if (companyManager != null && companyManager.ImageBytes != null)
                imageString = Convert.ToBase64String(companyManager.ImageBytes);
            companyManager.ImageString = imageString;

            return companyManager;
        }


        public async Task SoftDelete(int id)
        {
            var companyManager = await _companyManagerRepo.GetDefault(x => x.Id.Equals(id));

            if (companyManager is not null)
            {
                companyManager.DeletedDate = DateTime.Now;
                companyManager.Status = Status.Pasive;
                await _companyManagerRepo.Update(companyManager);
            }
        }

        public async Task Update(UpdateCompanyManagerDto model)
        {
            var companyManager = await _companyManagerRepo.GetDefault(x => x.Id == model.Id);

            companyManager.Address = model.Address;
            companyManager.PhoneNumber = model.PhoneNumber;
            //companyManager.ImagePath = model.ImagePath;

            companyManager.Status = Status.Modified;
            companyManager.UpdatedDate = DateTime.Now;

            await _companyManagerRepo.Update(companyManager);
        }


    }
}

