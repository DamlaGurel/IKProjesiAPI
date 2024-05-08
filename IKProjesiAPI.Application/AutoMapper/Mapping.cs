using AutoMapper;
using IKProjesiAPI.Application.Models.DTOs.AdvancePaymentDTOs;
using IKProjesiAPI.Application.Models.DTOs.CompanyDTOs;
using IKProjesiAPI.Application.Models.DTOs.CompanyManagerDTOs;
using IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs;
using IKProjesiAPI.Application.Models.DTOs.ExpenseDTOs;
using IKProjesiAPI.Application.Models.DTOs.OffDayDTOs;
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
            CreateMap<SiteManagerUpdateDto, SiteManager>().ReverseMap();

            CreateMap<Employee, CreateEmployeeDto>().ReverseMap();
            CreateMap<Employee, EmployeeSummaryDto>().ReverseMap();
            CreateMap<Employee, DetailEmployeeDto>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeDto>().ReverseMap();

            CreateMap<CreateAdvancePaymentDto, AdvancePayment>().ReverseMap();
            CreateMap<ListAdvancePaymentDto, AdvancePayment>().ReverseMap();
            CreateMap<AdvancePayment, ApprovalForAdvancePaymentDto>().ReverseMap();
            CreateMap<UpdateAdvancePaymentDto, AdvancePayment>().ReverseMap();

            CreateMap<Expense,CreateExpenseDto>().ReverseMap();
            CreateMap<Expense, ListExpenseDto>().ReverseMap();
            CreateMap<Expense, ApprovalForExpenseDto>().ReverseMap();
            CreateMap<UpdateExpenseDto, Expense>().ReverseMap();

            CreateMap<TakeOffDay, CreateOffDayDto>().ReverseMap();
            CreateMap<TakeOffDay, ListOffDayDto>().ReverseMap();
            CreateMap<TakeOffDay, ApprovalOffDayDto>().ReverseMap();
            CreateMap<UpdateOffDayDto, TakeOffDay >().ReverseMap();





        }
    }
}
