﻿using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Repositories;
using IKProjesiAPI.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Infrastructure.Repositories
{
    public class AppUserRoleRepo : BaseRepo<AppUserRole>, IAppUserRoleRepo
    {
        public AppUserRoleRepo(AppDbContext context) : base(context)
        {
        }
    }
}