using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PushSharp.Core;
using Tsy.Apns.Domain.Service;
using Tsy.Apns.WebApi.Models;
using PushSharp;
using PushSharp.Apple;
using Tsy.Apns.WebApi.Tools;

namespace Tsy.Apns.WebApi.Controllers
{
    [RoutePrefix("api/notify")]
    public class NotifyController : ApiController
    {
        private readonly IDeviceTokenService _service;

        public NotifyController(IDeviceTokenService service)
        {
            _service = service;
        }

        /// <summary>
        /// 注册设备
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="deviceToken">设备ID</param>
        /// <returns>成功可以返回数据库的记录ID</returns>
        [Route("register")]
        [HttpGet]
        public ResponseModel Register(string userId, string deviceToken)
        {
            var device = _service.SetDeviceForUser(userId, deviceToken);
            return new ResponseModel { Code = (int)HttpStatusCode.OK, Message = device.ToString() };
        }

        /// <summary>
        /// 关闭消息推送
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="enabled">开启传1（默认），关闭传0</param>
        /// <returns></returns>
        [Route("set")]
        [HttpGet]
        public ResponseModel SetStatus(string userId, int enabled = 1)
        {
            var result = _service.SetNotificationStatus(userId, enabled == 1);
            Log.Info("set status for userid: {0}, status: {1}, result: {2}", User, enabled, result);
            return result ? new ResponseModel { Code = (int)HttpStatusCode.OK, Message = "notification truned " + (enabled == 1 ? "on" : "off") } : new ResponseModel { Code = (int)HttpStatusCode.NotFound, Message = "未注册的设备" };
        }

        /// <summary>
        /// 给指定用户发送消息 
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="badges">用户待办消息的条数，不支持的话传0</param>
        /// <param name="message">消息内容，可为空</param>
        /// <returns></returns>
        [Route("send")]
        [HttpGet]
        public ResponseModel Send(string userId, int badges = 0, string message = "有新的待办事项")
        {
            var device = _service.GetDevice(userId);
            if (device == null)
            {
                return new ResponseModel
                {
                    Code = (int)HttpStatusCode.NotFound,
                    Message = "该用户设备未注册"
                };
            }
            if (device.Enabled != 1)
            {
                return new ResponseModel
                {
                    Code = (int)HttpStatusCode.MethodNotAllowed,
                    Message = "用户设置为不接收推送消息"
                };
            }
            try
            {
                PushService.SendWithApns(device.DeviceToken, message, badges);
                return new ResponseModel
                {
                    Code = (int)HttpStatusCode.OK,
                    Message = "消息已提交到发送队列"
                };
            }
            catch (Exception ex)
            {
                while(ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                Logger.Error(ex.Message);
                return new ResponseModel
                {
                    Code = (int)HttpStatusCode.InternalServerError,
                    Message = ex.Message
                };
            }
        }
    }
}
