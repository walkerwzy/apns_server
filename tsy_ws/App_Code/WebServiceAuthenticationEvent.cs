using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace tsy_ws
{
    public class WebServiceAuthenticationEvent : EventArgs
    { 
       private IPrincipal _IPrincipalUser;
       private HttpContext _Context;
       private string _User;
       private string _Password;

       public WebServiceAuthenticationEvent(HttpContext context)
       {
            _Context = context;
       }

       public WebServiceAuthenticationEvent(HttpContext context,
                       string user, string password)
       {
           _Context = context;
           _User = user;
           _Password = password;
       }
       public  HttpContext Context 
       { 
         get { return _Context;}
       }
       public IPrincipal Principal 
       { 
         get { return _IPrincipalUser;} 
         set { _IPrincipalUser = value;}
       }
       public void Authenticate()
       {
         GenericIdentity i = new GenericIdentity(User);
         this.Principal = new GenericPrincipal(i, new String[0]);
       }
       public void Authenticate(string[] roles)
       {
         GenericIdentity i = new GenericIdentity(User);
         this.Principal = new GenericPrincipal(i, roles);
       }
       public string User 
       {
         get { return _User; }
         set { _User = value; }
       }
       public string Password
       {
         get { return _Password; }
         set { _Password = value; }
       }
       public bool HasCredentials {
         get 
         {
              if ((_User == null) || (_Password == null))
                return false;
              return true;
         }
       }
    }
}