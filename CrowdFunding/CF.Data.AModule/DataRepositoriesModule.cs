﻿using Autofac;
using CF.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Data.AModule
{
    public class DataRepositoriesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new UnitOfWorkManager())
                .As<IUnitOfWorkManager>();
        }
    }
}
