using MyPersonalTutorial.Contracts;
using MyPersonalTutorial.ModelBuilders;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPersonalTutorial
{
    public class WebModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEmployeeModelBuilder>().To<EmployeeModelBuilder>().InRequestScope();
        }
    }
}