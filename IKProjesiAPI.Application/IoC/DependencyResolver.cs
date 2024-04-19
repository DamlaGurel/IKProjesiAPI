using Autofac;
using IKProjesiAPI.Application.Services.SiteManagerService;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Application.IoC
{
    public class DependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SiteManagerRepo>().As<ISiteManagerRepo>().InstancePerLifetimeScope();

            builder.RegisterType<SiteManagerService>().As<ISiteManagerService>().InstancePerLifetimeScope();




            base.Load(builder);
        }
    }
}
