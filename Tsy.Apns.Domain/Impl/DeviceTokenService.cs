using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Tsy.Apns.Domain.Models;
using Tsy.Apns.Domain.Repository;
using Tsy.Apns.Domain.Service;

namespace Tsy.Apns.Domain.Impl
{
    public class DeviceTokenService : IDeviceTokenService
    {
        private DeviceTokenRepotitory _repo;

        public DeviceTokenService()
        {
            _repo = new DeviceTokenRepotitory();
        }
        public Devices GetDevice(string userId)
        {
            return _repo.GetDevices(userId, "").FirstOrDefault();
        }

        public long SetDeviceForUser(string userId, string deviceToken)
        {
            // 一设备一用户，所以先移除所有关联
            var devices = _repo.GetDevices(userId, deviceToken);
            foreach (var d in devices)
            {
                // 用户未更改用户-设备 的关联，则直接打开推送即可
                if (d.UserId == userId && d.DeviceToken == deviceToken)
                {
                    d.Enabled = 1;
                    _repo.Update(d);
                    return d.Id;
                }
                _repo.Delete(d);
            }
            _repo.Add(new Devices { UserId = userId, DeviceToken = deviceToken, Enabled = 1 });
            return _repo.GetOne(userId, deviceToken).Id;
        }

        public bool SetNotificationStatus(string userId, bool enabled)
        {
            var device = _repo.GetDevices(userId, "").FirstOrDefault();
            if (device == null) return false;
            device.Enabled = enabled ? 1 : 0;
            _repo.Update(device);
            return true;
        }


        public void RemoveDevice(string userId)
        {
            var devices = _repo.GetDevices(userId, "");
            foreach (var device in devices)
            {
                _repo.Delete(device);
            }
        }
    }
}
