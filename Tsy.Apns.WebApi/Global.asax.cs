using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using Tsy.Apns.Domain.Impl;
using Tsy.Apns.Domain.Service;

namespace Tsy.Apns.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);


            //按如下步骤添加
            // 1. Create a new Simple Injector container
            var container = new Container();

            // a.1 webapi, frist register controller 修改点1
            var services = GlobalConfiguration.Configuration.Services;
            var controllerTypes = services.GetHttpControllerTypeResolver()
                .GetControllerTypes(services.GetAssembliesResolver());

            // register Web API controllers (important! http://bit.ly/1aMbBW0)
            foreach (var controllerType in controllerTypes)
            {
                container.Register(controllerType);
            }

            // 2. Configure the container (register)
            container.Register<IDeviceTokenService, DeviceTokenService>(Lifestyle.Transient);

            // 3. Optionally verify the container's configuration.
            container.Verify();

            // 4. Store the container for use by Page classes.
            //WebApiApplication.Container = container;
            //System.Web.Mvc.DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

            // a.2 webapi  按照文档，写在verify()后面 修改点2
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            // 5. register global filters //如果有注册全局过滤器的需要加此节点，和下面注释掉的方法
            //RegisterGlobalFilters(GlobalFilters.Filters, container);
        }
    }
}
