using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace tsy_ws
{
    public class log
    {
        public static object o = new object();

        public static void write(string message)
        {
            string filePath = HttpContext.Current.Server.MapPath("~/test.log");
            lock (o)
            {
                if (!File.Exists(filePath))
                {
                    var file = File.Create(filePath);
                    file.Close();
                }
                using (var fs = new StreamWriter(filePath, true))
                {
                    string m = string.Format("{0}:{1}", DateTime.Now.ToString("s"), message);
                    fs.WriteLine(m);
                }
            }
        }
    }
}