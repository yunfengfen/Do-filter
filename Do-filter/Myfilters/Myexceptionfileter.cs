using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Do_filter.Myfilters
{
    public class Myexceptionfileter:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //不能注释，否则铺货不了异常
            base.OnException(filterContext);
            // filterContext.HttpContext.Response.Write("我是异常过滤器");
            filterContext.Result = new RedirectResult("/error/400.html");

        }
    }
}