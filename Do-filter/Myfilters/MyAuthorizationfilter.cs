using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Do_filter.Myfilters
{
    public class MyAuthorizationfilter:AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //如果保留以下代码，则会运行.net framework 定义好的身份验证,如果想要自定义身份验证，则需要删除以下代码
            // base.OnAuthorization(filterContext);

            //如果需要跳转到另一个界面，需要使用Result，而不是使用Respose.Redirect(),第二种方案不回让服务器停止
          //  filterContext.Result = new RedirectResult(UrlHelper.GenerateUrl("", "Index", "AuthorizationController"));
          //获取路由数据：当前上下文匹配路由规则后，得到一个对像
            ///  filterContext.RouteData;
            ///  获取上下文
           filterContext.HttpContext.Response.Write("666");
           
        }
    }
}