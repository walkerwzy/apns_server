using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace Tsy.Apns.WebApi.Tools
{
    public class Logger
    {
        private static object o = new object();

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="level">0:debug, 1:info, 2:error</param>
        /// <param name="message"></param>
        private static void Write(int level, string message)
        {
            string txtLevel = "debug";
            if (level == 1) txtLevel = "info";
            else if (level == 2) txtLevel = "error";
            var folderPath = "SystemLogs";
            makeLogFolder(folderPath);
            var monthStr = DateTime.Now.ToString("yyyyMM");
            string filePath = HttpContext.Current.Server.MapPath("~/" + folderPath + "/" + monthStr +".log");
            lock (o)
            {
                if (!File.Exists(filePath))
                {
                    var file = File.Create(filePath);
                    file.Close();
                }
                using (var fs = new StreamWriter(filePath, true))
                {
					string m = string.Format("{0} [{1}]:{2}", DateTime.Now.ToString("s"), txtLevel, message);
                    fs.WriteLine(m);
                }
            }
        }

        public static void Debug(string message)
        {
            Write(0, message);
        }

        public static void Info(string message)
        {
            Write(1, message);
        }

        public static void Error(string message)
        {
            Write(2, message);
        }

        private static void makeLogFolder(string folderPath)
        {
            folderPath = HttpContext.Current.Server.MapPath("~/" + folderPath);
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }
    }
}