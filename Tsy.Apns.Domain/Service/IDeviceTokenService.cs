using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsy.Apns.Domain.Models;

namespace Tsy.Apns.Domain.Service
{
    public interface IDeviceTokenService
    {
        /// <summary>
        /// 根据UserId获取设备信息
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns></returns>
        Devices GetDevice(string userId);

        /// <summary>
        /// 添加/修改用户-设备的映射
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="deviceToken">从APNS服务器获取的device token</param>
        /// <returns></returns>
        long SetDeviceForUser(string userId, string deviceToken);

        /// <summary>
        /// 开启/关闭消息推送
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="enabled">推送状态</param>
        bool SetNotificationStatus(string userId, bool enabled);

        /// <summary>
        /// 移除用户关联的所有设备ID
        /// 用户每换一台设备，均可调此方法清掉之前关联的所有设备
        /// </summary>
        /// <param name="userId">用户ID</param>
        void RemoveDevice(string userId);
    }
}
