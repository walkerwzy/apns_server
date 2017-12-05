using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tsy_ws
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var service = new localSrv.MobileWebService();
            var header = new localSrv.UserCredentials {UserName = DateTime.Now.ToString("O"), Password = "bbb"};
            service.UserCredentialsValue = header;
            Response.Write(service.Mobile_App_Empty("aa"));
        }
    }
}