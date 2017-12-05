using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;
using Tsy.Apns.WebApi.Models;
using Tsy.Apns.WebApi.Tools;

namespace Tsy.Apns.WebApi.Filters
{
    public class WebApiGloalErrorHandler :ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            Exception ex = actionExecutedContext.Exception;
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            Logger.Error(ex.Message);
            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(
                HttpStatusCode.InternalServerError,
                new ResponseModel
                {
                    Code = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                });
        }
    }
}