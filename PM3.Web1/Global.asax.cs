using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using PM3.Data;
using PM3.Data.Infrastructure;
using PM3.Data.Repositories;
using PM3.Service;
using PM3.Web1.Modules;
using PM3.Web2;
using PM3.Model.Models;

namespace PM3.Web1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Autofac Configuration
            var builder = new Autofac.ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            builder.RegisterModule(new RepositoryModule());
            builder.RegisterModule(new ServiceModule());
            builder.RegisterModule(new EFModule());

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //using (var ctx = new Pm3Entities())
            //{
            //    // create and seed the db
            //    //ctx.Database.Initialize(true);

            //    //// load elements to use AccidentCodeService
            //    //var dbf = new DbFactory();
            //    //var acr = new AccidentCodeRepository(dbf);
            //    //var ui = new UnitOfWork(dbf);
            //    //var acs = new AccidentCodeService(acr, ui);

            //    //// add a code to our table
            //    //if (acs.GetAccidentCode("E") == null)
            //    //{
            //    //    var ac = new AccidentCode
            //    //    {
            //    //        AccidentCodeId = "E",
            //    //        Description = "E description"
            //    //    };
            //    //    acs.CreateAccidentCode(ac);
            //    //    acs.SaveAccidentCode();
            //    //}
            //    //else
            //    //{
            //    //    AccidentCode accidentCode = acs.GetAccidentCode("E");
            //    //    accidentCode.Description = "Some Other New description for E";
            //    //    acs.Update(accidentCode);
            //    //    acs.SaveAccidentCode();
            //    //}
            //}
        }
    }
}
