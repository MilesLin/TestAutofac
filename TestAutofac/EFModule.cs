using Autofac;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TestAutofac.Models;

namespace TestAutofac
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            //要怎麼完成IUnitOfWork Property Inject ><"

            //builder.RegisterType(typeof(DotNetCoreEntities)).As(typeof(DbContext)).InstancePerLifetimeScope();
            //builder.RegisterType(typeof(EFUnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
            //builder.RegisterType<IPersonsRepository>().WithProperty("UnitOfWork", new EFUnitOfWork());
            //builder.RegisterType<PersonsRepository>().WithProperty("UnitOfWork", new EFUnitOfWork());
            //builder.RegisterType<IRepository<Persons>>().WithProperty("UnitOfWork", new EFUnitOfWork());
            //builder.RegisterType<IUnitOfWork>().WithProperty("UnitOfWork", new EFUnitOfWork());
            //builder.RegisterType<IRepository<Persons>>().PropertiesAutowired();

        }

    }
}
