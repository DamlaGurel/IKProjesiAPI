using System;
using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace IKProjesiAPI.Application.Services.CompanyManagerService
{
    public class CompanyManagerService : ICompanyManagerService
    {

        private readonly ICompanyManagerRepo _companyManagerRepo;
        private readonly ICompanyRepo _companyRepo;
        private readonly IPersonelRepo _personelRepo;
        private readonly IMapper _mapper;


        public CompanyManagerService(ICompanyManagerRepo companyManagerRepo, ICompanyRepo companyRepo, IMapper mapper, IPersonelRepo personelRepo)
        {
            _companyRepo = companyRepo;
            _companyManagerRepo = companyManagerRepo;
            _mapper = mapper;
            _personelRepo = personelRepo;
        }
        public async Task Create(CreateCompanyManagerDto model)
        {
            
            var companyManager = _mapper.Map<CompanyManager>(model);
            companyManager.Email = $"{model.FirstName}.{model.LastName}@bilgeadamboost.com";
            companyManager.UserName = companyManager.Email;
            companyManager.NormalizedUserName = companyManager.Email.ToUpper();
             await _companyManagerRepo.Create(companyManager);
            

           



        }

        public async Task Delete(int id)
        {
            var companyManager = await _companyManagerRepo.GetDefault(x => x.Id.Equals(id));
            await _companyManagerRepo.Delete(companyManager);

        }

        public async Task<UpdateCompanyManagerDto> GetCompanyManagerById(int id)
        {
            var companyManager = await _companyManagerRepo.GetFilteredFirstOrDefault(select: x => _mapper.Map<UpdateCompanyManagerDto>(x), where: x => x.Id == id);
            return companyManager;
        }

        public async Task<List<ListCompanyManagerDto>> GetCompanyManagers()
        {
            var companyManager = await _companyManagerRepo.GetFilteredList(select: x => _mapper.Map<ListCompanyManagerDto>(x),
                where: x => !x.Status.Equals(Status.Pasive),
                orderBy: x => x.OrderBy(x => x.Id));
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
            var companyManager = await _companyManagerRepo.GetFilteredFirstOrDefault(
                select: x => _mapper.Map<SummaryCompanyManagerDto>(x),
                where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

            return companyManager;
        }

        public async Task<DetailCompanyManagerDto> GetCompanyManagerDetails(int id)
        {
            var companyManager = await _companyManagerRepo.GetFilteredFirstOrDefault(
                select: x => _mapper.Map<DetailCompanyManagerDto>(x),
                where: s => s.Id.Equals(id) && s.Status != Status.Pasive);

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
            companyManager.ImagePath = model.ImagePath;

            companyManager.Status = Status.Modified;
            companyManager.UpdatedDate = DateTime.Now;

            await _companyManagerRepo.Update(companyManager);
        }


        //-------------------------------
        //PERSONEL İŞLEMLERİ
        //-------------------------------

        public async Task CreatePersonel(CreatePersonelDto model)
        {
            var personel = _mapper.Map<Personel>(model);

            await _personelRepo.Create(personel);
        }
    }
}

