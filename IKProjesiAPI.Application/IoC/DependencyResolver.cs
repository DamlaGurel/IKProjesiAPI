using Autofac;
using AutoMapper;
using IKProjesiAPI.Application.AutoMapper;
using IKProjesiAPI.Application.Services.CompanyManagerService;
using IKProjesiAPI.Application.Services.CompanyService;
using IKProjesiAPI.Application.Services.SiteManagerService;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace IKProjesiAPI.Application.IoC
{
    public class DependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SiteManagerRepo>().As<ISiteManagerRepo>().InstancePerLifetimeScope();
            builder.RegisterType<SiteManagerService>().As<ISiteManagerService>().InstancePerLifetimeScope();

            builder.RegisterType<CompanyService>().As<ICompanyService>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyRepo>().As<ICompanyRepo>().InstancePerLifetimeScope();

            builder.RegisterType<CompanyManagerService>().As<ICompanyManagerService>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyManagerRepo>().As<ICompanyManagerRepo>().InstancePerLifetimeScope();

            builder.Register(context => new MapperConfiguration(config =>
            {
                config.AddProfile<Mapping>();
            })).AsSelf().SingleInstance();

            builder.Register(c => {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();
                return config.CreateMapper(context.Resolve);

            }).As<IMapper>()
              .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
