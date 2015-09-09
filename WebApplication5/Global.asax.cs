using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication5.Models;

namespace WebApplication5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static System.Timers.Timer timer = new System.Timers.Timer(60000); // This will raise the event every one minute.
        //public static DateTime now = System.DateTime.Now;
        public static int n;
        
        protected void Application_Start()
        {
            Sample.LabelName = "Blah";
            timer.Enabled = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }

        static void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            Sample.LabelName = (n++).ToString();

        }
    }
}
