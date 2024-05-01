using Autofac;
using AutoMapper;
using IKProjesiAPI.Application.AutoMapper;
using IKProjesiAPI.Application.Services.AppUserService;
using IKProjesiAPI.Application.Services.CompanyManagerService;
using IKProjesiAPI.Application.Services.CompanyService;
using IKProjesiAPI.Application.Services.EmployeeService;
using IKProjesiAPI.Application.Services.SiteManagerService;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Repositories;
using Module = Autofac.Module;

namespace IKProjesiAPI.Application.IoC
{
    public class DependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SiteManagerService>().As<ISiteManagerService>().InstancePerLifetimeScope();
            builder.RegisterType<SiteManagerRepo>().As<ISiteManagerRepo>().InstancePerLifetimeScope();

            builder.RegisterType<CompanyService>().As<ICompanyService>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyRepo>().As<ICompanyRepo>().InstancePerLifetimeScope();

            builder.RegisterType<CompanyManagerService>().As<ICompanyManagerService>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyManagerRepo>().As<ICompanyManagerRepo>().InstancePerLifetimeScope();

            builder.RegisterType<AppUserService>().As<IAppUserService>().InstancePerLifetimeScope();
            builder.RegisterType<AppUserRepo>().As<IAppUserRepo>().InstancePerLifetimeScope();

            builder.RegisterType<AppRoleRepo>().As<IAppRoleRepo>().InstancePerLifetimeScope();

            builder.RegisterType<AppUserRoleRepo>().As<IAppUserRoleRepo>().InstancePerLifetimeScope();

            builder.RegisterType<EmployeeService>().As<IEmployeeService>().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeRepo>().As<IEmployeeRepo>().InstancePerLifetimeScope();

            builder.RegisterType<ExpenseRepo>().As<IExpenseRepo>().InstancePerLifetimeScope();
            builder.RegisterType<AdvancePaymentRepo>().As<IAdvancePaymentRepo>().InstancePerLifetimeScope();
            builder.RegisterType<TakeOffDayRepo>().As<ITakeOffDayRepo>().InstancePerLifetimeScope();




            builder.Register(context => new MapperConfiguration(config =>
            {
                config.AddProfile<Mapping>();
            })).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);

            }).As<IMapper>()
              .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
