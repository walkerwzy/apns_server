using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using PushSharp.Core;
using Tsy.Apns.Domain.Models;
using Tsy.Apns.Domain.Service;
using Tsy.Apns.WebApi.Tools;

namespace Tsy.Apns.WebApi.Controllers
{
    public class TestController : ApiController
    {
        private readonly IDeviceTokenService _service;

        public TestController(IDeviceTokenService service)
        {
            _service = service;
        }
        [Route("api/test/id")]
        [HttpGet]
        public Devices aaa(string uid)
        {
            var d = _service.GetDevice(uid);
            return d;
        }

        [Route("api/test/log")]
        [HttpGet]
        public HttpResponseMessage WriteLog()
        {
            Logger.Error("测试错误日志");
            Logger.Info("测试信息日志");
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/test/upload")]
        [HttpPost]
        public async Task<HttpResponseMessage> PostFormData()
        {
            // Check if the request contains multipart/form-data.
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            string root = HttpContext.Current.Server.MapPath("~/App_Data");
            var provider = new MultipartFormDataStreamProvider(root);

            try
            {
                // Read the form data.
                await Request.Content.ReadAsMultipartAsync(provider);

                // This illustrates how to get the file names.
                foreach (MultipartFileData file in provider.FileData)
                {
                    Logger.Info(file.LocalFileName+","+file.Headers.ContentDisposition.FileName+","+file.Headers.ContentDisposition.FileNameStar);
                    var fn = Path.GetFileName(file.Headers.ContentDisposition.FileName.Replace("\"", ""));
                    var fi = new FileInfo(file.LocalFileName);
                    fi.MoveTo(Path.Combine(root,fn));
                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        [Route("api/test/upload2")]
        [HttpPost]
        public HttpResponseMessage Post()
        {
            HttpResponseMessage result = null;
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                var docfiles = new List<string>();
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    var filePath = HttpContext.Current.Server.MapPath("~/App_Data" + postedFile.FileName);
                    postedFile.SaveAs(filePath);

                    docfiles.Add(filePath);
                }
                result = Request.CreateResponse(HttpStatusCode.Created, docfiles);
            }
            else
            {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            return result;
        }
    }
}
