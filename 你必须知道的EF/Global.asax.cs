using StackExchange.Profiling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcApplication3
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            //if (Request.IsLocal)//这里是允许本地访问启动监控,可不写
            //{
            //MiniProfiler.Start();

            //}
#if DEBUG
            StackExchange.Profiling.EntityFramework6.MiniProfilerEF6.Initialize();
#endif

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //MiniProfiler.Start();

        }

        protected void Application_BeginRequest()
        {
            //解决iframe 中cookie 和session 丢失的问题
            HttpContext.Current.Response.AddHeader("P3P", "CP=CAO PSA OUR");
#if DEBUG
            MiniProfiler.Start();
#endif
        }

        protected void Application_EndRequest()
        {
#if DEBUG
            MiniProfiler.Stop();
#endif
        }

        //protected void Application_EndRequest()
        //{
        //    MiniProfiler.Stop();
        //}
    }
}