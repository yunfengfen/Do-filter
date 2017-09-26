using Do_filter.Myfilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Do_filter.Controllers
{
   // [MyAuthorizationfilter]当前控制器下面的行文应用到了这个身份验证
    public class AuthorizationController : Controller
    {
        // GET: Authorization
       // [MyAuthorizationfilter]//当前行为在执行前，会先执行身份验证
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Author()
        //{

        //}
        //过滤器的第二种方式：重写控制器的方法，这样，会应用到所有的行为
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            // base.OnAuthorization(filterContext);
            //filterContext.HttpContext.Response.Write("我是第二种方式");
        }
       //[Myexceptionfileter]
        public ActionResult Exceptions()
        {
            
            //  return Content("我是exceptions行为");
            return View();
        }
       // [MyActionFilter]
        //ActionResult是行为的结果，所以最后发生
        public ActionResult Action()
        {
            return Content("我是行为中1");
        }
        [MyResultFilter]
        public ActionResult Results()
        {
            return Content("我是结果");
        }
    }
}