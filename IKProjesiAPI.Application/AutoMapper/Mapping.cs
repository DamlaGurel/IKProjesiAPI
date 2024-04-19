using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.CompanyDTOs;

using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;

using IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs;

using IKProjesiAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.AutoMapper
{
    public class Mapping :Profile
    {
        public Mapping()
        {
            CreateMap<Company, CreateCompanyDto>().ReverseMap();
            CreateMap<Company, CompanyListDto>().ReverseMap();

            CreateMap<CompanyManager, CreateCompanyManagerDto>().ReverseMap();
            CreateMap<CompanyManager, UpdateCompanyManagerDto>().ReverseMap();
            CreateMap<CompanyManager, ListCompanyManagerDto>().ReverseMap();

            CreateMap<SiteManager, CreateSiteManagerDto>().ReverseMap();
            CreateMap<CreateSiteManagerDto, SiteManager>().ReverseMap();
            CreateMap<SiteManager, SiteManagerUpdateDto>().ReverseMap();
            CreateMap<SiteManagerDetailsDto, SiteManager>().ReverseMap();
            CreateMap<SiteManagerSummaryDto, SiteManager>().ReverseMap();


        }
    }
}
