using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebAppErrorHandling
{
    public class Global : System.Web.HttpApplication
    {
       
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        void Application_Error(object sender, EventArgs e)
        {
            Exception ex=Server.GetLastError();
            Server.ClearError();
            //log the Exception if needed

            //Redirect to appropriate error page

            if(ex is HttpException)
            {
                HttpException httpEx=ex as HttpException;
                int statusCode=httpEx.GetHttpCode();
                if(statusCode == 404)
                {
                    Response.Redirect("~/Error404.aspx");
                }
                if (statusCode == 500)
                {
                    Response.Redirect("~/Error500.aspx");
                }
            }
            else
            {
                Response.Redirect("~/Error.aspx");
            }
        }
    }
}