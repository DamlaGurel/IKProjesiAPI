﻿using System;
using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;
using IKProjesiAPI.Domain.Repositories;

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
        public async Task Create(CreateCompanyManagerDto model)
        {
            var companyManager = _mapper.Map<CompanyManager>(model);
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

        public Task Update(UpdateCompanyManagerDto model)
        {
            throw new NotImplementedException();
        }

        //public async Task Update(UpdateCompanyManagerDto model)
        //{

        //var companyManager = await _companyManagerRepo.GetFilteredList(select: x => _mapper.Map<UpdateCompanyManagerDto>(x),
        //where: x => !x.Status.Equals(Status.Pasive),
        // orderby: x => x.OrderBy(x => x.Id));
        //return companyManager;
        //}
    }
}
