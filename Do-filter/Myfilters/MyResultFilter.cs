using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Do_filter.Myfilters
{
    public class MyResultFilter:ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            // base.OnResultExecuting(filterContext);
            filterContext.HttpContext.Response.Write("我是结果之前的过滤器");
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            // base.OnResultExecuted(filterContext);
            filterContext.HttpContext.Response.Write("我是结果之后的过滤器");
        }
    }
}