using System;
using System.Configuration;
using PushSharp.Apple;
using Newtonsoft.Json.Linq;
using System.Web;

namespace Tsy.Apns.WebApi.Tools
{
    public class PushService
    {
        public static void SendWithApns(string deviceToken, string message, int badges)
        {
            var isProduction = string.Compare("true", ConfigurationManager.AppSettings.Get("apns:debug"), StringComparison.OrdinalIgnoreCase) != 0;
            var env = isProduction ? ApnsConfiguration.ApnsServerEnvironment.Production : ApnsConfiguration.ApnsServerEnvironment.Sandbox;
            var certFileName = ConfigurationManager.AppSettings.Get("apns:certname");
            var file = HttpContext.Current.Server.MapPath("~/Certs/" + certFileName);
            var certKey = ConfigurationManager.AppSettings.Get("apns:certkey");
            var config = new ApnsConfiguration(env, file, certKey);

            var apnsBroker = new ApnsServiceBroker(config);

            apnsBroker.OnNotificationFailed += (notification, aggregateEx) =>
            {
                aggregateEx.Handle(ex =>
                {
                    // See what kind of exception it was to further diagnose
                    if (ex is ApnsNotificationException)
                    {
                        var notificationException = (ApnsNotificationException)ex;
                        // Deal with the failed notification
                        var apnsNotification = notificationException.Notification;
                        var statusCode = notificationException.ErrorStatusCode;
                        var error = ex.InnerException;
                        while (error.InnerException != null)
                        {
                            error = error.InnerException;
                        }
                        Logger.Error($"Apple Notification Failed: ID={apnsNotification.Identifier}, Code={statusCode}, Device={apnsNotification.DeviceToken}, Reason={ex.Message},{error.Message}");
                    }
                    else
                    {
                        // Inner exception might hold more useful information like an ApnsConnectionException           
                        Console.WriteLine($"Apple Notification Failed for some unknown reason : {ex.InnerException}");
                    }
                    // Mark it as handled
                    return true;
                });
            };

            apnsBroker.OnNotificationSucceeded += (notification) => {
                // 如果要写数据库日志的话
                Console.WriteLine("Apple Notification Sent!");
            };

            apnsBroker.Start();

            apnsBroker.QueueNotification(new ApnsNotification
            {
                DeviceToken = deviceToken,
                Payload = JObject.Parse($"{{\"aps\":{{\"alert\":\"{message}\",\"badge\":{badges},\"sound\":\"default\"}},\"data\":{{}}}}")
            });
            apnsBroker.Stop();
        }

        //public static void SendWithApns(string deviceToken, string message, int badges)
        //{
        //    var certFileName = ConfigurationManager.AppSettings.Get("apns:certname");
        //    var certKey = ConfigurationManager.AppSettings.Get("apns:certkey");
        //    var push = new PushBroker();
        //    var file = HttpContext.Current.Server.MapPath("~/Certs/" + certFileName);
        //    var isProduction = System.String.Compare("true", ConfigurationManager.AppSettings.Get("apns:debug"), System.StringComparison.OrdinalIgnoreCase) != 0;
        //    push.OnNotificationSent += push_OnNotificationSent;
        //    push.OnNotificationFailed += push_OnNotificationFailed;
        //    var appleCert = File.ReadAllBytes(file);
        //    push.RegisterAppleService(new ApplePushChannelSettings(isProduction, appleCert, certKey));
        //    push.QueueNotification(new AppleNotification()
        //        .ForDeviceToken(deviceToken)
        //        .WithAlert(message)
        //        .WithBadge(badges)
        //        //.WithCustomItem("data", new { id = "RT33445566", type = 21, content = "you have new report", date = 12342314 })
        //        //.WithCustomItem("data", new Dictionary<string, string>
        //        //{
        //        //    {"id","QA2349823"},
        //        //    {"type","21"},
        //        //    {"content","you've got a message"},
        //        //    {"date","21349823174"}
        //        //})
        //        //.WithCustomItem("data","aaa","bbb",33,44,"ccc")
        //        .WithCustomItem("data", "{\"id\":\"AQ2394832\",\"type\":21,\"content\":\"you'v got a new message\",\"date\":1234132413}")
        //        //.WithCustomItem("data", new KeyValuePair<string, string>("id","AQfdlskfjs"))
        //        .WithSound("sound.caf"));
        //}

        //static void push_OnNotificationFailed(object sender, PushSharp.Core.INotification notification, Exception error)
        //{
        //    while (error.InnerException != null)
        //    {
        //        error = error.InnerException;
        //    }
        //    Logger.Error("发送消息失败：" + error.Message);
        //}

        //static void push_OnNotificationSent(object sender, PushSharp.Core.INotification notification)
        //{
        //    //
        //}
    }
}