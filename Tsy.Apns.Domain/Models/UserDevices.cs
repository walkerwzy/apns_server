using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsy.Apns.Domain.Models
{
    public class DeviceDbContext : DbContext
    {
        public DeviceDbContext()
        {
            Database.SetInitializer<DeviceDbContext>(null);
        }

        public DbSet<Devices> Devices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Database does not pluralize table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    public class Devices
    {
        /// <summary>
        /// 记录ID
        /// </summary>
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        [Column("userid")]
        public string UserId { get; set; }
        /// <summary>
        /// APNS认证设备号
        /// </summary>
        [Column("devicetoken")]
        public string DeviceToken { get; set; }
        /// <summary>
        /// 是否开启消息推送
        /// </summary>
        [Column("enabled")]
        public int Enabled { get; set; }
    }
}
