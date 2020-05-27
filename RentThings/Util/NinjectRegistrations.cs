using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using RentThings.Interfaces;
using RentThings.Services;

namespace RentThings.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRentService>().To<EntityRentService>();
            Bind<IAccountService>().To<EntityAccountService>();
        }
    }
}