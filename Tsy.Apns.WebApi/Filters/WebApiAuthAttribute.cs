using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Tsy.Apns.WebApi.Models;

namespace Tsy.Apns.WebApi.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class WebApiAuthAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            // 这是一个基本例子，使用的ASP.NET Forms 身份验证
            //var context = HttpContext.Current;
            //if (context.User.Identity.IsAuthenticated == false)
            //{
            //PreUnauthorized(actionContext);
            //    return;
            //}
        }

        private void PreUnauthorized(HttpActionContext actionContext)
        {
            actionContext.Response = actionContext.Request.CreateResponse(
                HttpStatusCode.OK,
                new ResponseModel
                {
                    Code = (int)HttpStatusCode.Unauthorized,
                    Message = "鉴权失败"
                });
        }
    }
}