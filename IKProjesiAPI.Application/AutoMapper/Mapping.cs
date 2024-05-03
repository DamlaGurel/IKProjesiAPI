﻿using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyDTOs;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Entities.AppEntities;

namespace IKProjesiAPI.Application.AutoMapper
{
    public class Mapping :Profile
    {
        public Mapping()
        {
            CreateMap<Company, CreateCompanyDto>().ReverseMap();
            CreateMap<Company, CompanyListDto>().ReverseMap();
            CreateMap<Company, CompanyDetailsDto>().ReverseMap();

            CreateMap<CompanyManager, CreateCompanyManagerDto>().ReverseMap();
            CreateMap<CompanyManager, UpdateCompanyManagerDto>().ReverseMap();
            CreateMap<CompanyManager, ListCompanyManagerDto>().ReverseMap();
            //CreateMap<CreateCompanyManagerDto, CompanyManager>().ReverseMap();
            CreateMap<SummaryCompanyManagerDto, CompanyManager>().ReverseMap();
            CreateMap<DetailCompanyManagerDto, CompanyManager>().ReverseMap();

            CreateMap<SiteManager, CreateSiteManagerDto>().ReverseMap();
            CreateMap<SiteManager, SiteManagerUpdateDto>().ReverseMap();
            CreateMap<CreateSiteManagerDto, SiteManager>().ReverseMap();
            CreateMap<SiteManagerDetailsDto, SiteManager>().ReverseMap();
            CreateMap<SiteManagerSummaryDto, SiteManager>().ReverseMap();

            CreateMap<CreateEmployeeDto,Employee>().ReverseMap();

            CreateMap<CreateAdvancePaymentDto, AdvancePayment>().ReverseMap();

            CreateMap<Expense,CreateExpenseDto>().ReverseMap();

        }
    }
}
