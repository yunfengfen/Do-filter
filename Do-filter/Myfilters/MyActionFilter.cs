using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Do_filter.Myfilters
{
    public class MyActionFilter:ActionFilterAttribute
    {
        //行为之前进行的行为过率器
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // base.OnActionExecuting(filterContext);
            filterContext.HttpContext.Response.Write("我是行为前过滤器");

        }
        //行为之后的行为过滤器
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // base.OnActionExecuted(filterContext);
            filterContext.HttpContext.Response.Write("我是行为后的过滤器");
        }
    }
}