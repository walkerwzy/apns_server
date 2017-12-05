using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Tsy.Apns.WebApi.Filters;

namespace Tsy.Apns.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // 全局鉴权和异常
            config.Filters.Add(new WebApiAuthAttribute());
            config.Filters.Add(new WebApiGloalErrorHandler());

            var json = config.Formatters.JsonFormatter;
            // 解决json序列化时的循环引用问题
            json.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            // 移除XML序列化器
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
