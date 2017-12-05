using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsy.Apns.Domain.Models;

namespace Tsy.Apns.Domain.Repository
{
    internal class DeviceTokenRepotitory : IDisposable
    {
        private readonly DeviceDbContext _context;
        public DeviceTokenRepotitory()
        {
            _context = new DeviceDbContext();
        }

        public IQueryable<Devices> GetDevices(string userId, string deviceToken)
        {
            return _context.Devices.Where(d => d.UserId == userId || d.DeviceToken == deviceToken);
        }

        public Devices GetOne(string userId, string deviceToken)
        {
            return _context.Devices.FirstOrDefault(d => d.UserId == userId && d.DeviceToken == deviceToken);
        }

        public IQueryable<Devices> GetAllUserByToken(string deviceToken)
        {
            return _context.Devices.Where(d => d.DeviceToken == deviceToken);
        }

        public void Add(Devices device)
        {
            _context.Devices.Add(device);
            _context.SaveChanges();
        }

        public void Delete(Devices device)
        {
            _context.Devices.Remove(device);
            _context.SaveChanges();
        }

        public void Update(Devices device)
        {
            var d = _context.Devices.FirstOrDefault(m => m.Id == device.Id);
            if (d != null)
            {
                d.UserId = device.UserId;
                d.DeviceToken = device.DeviceToken;
                d.Enabled = device.Enabled;
                _context.SaveChanges();
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
