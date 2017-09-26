using Do_filter.Myfilters;
using System.Web;
using System.Web.Mvc;

namespace Do_filter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // filters.Add(new HandleErrorAttribute());
            // filters.Add(new MyAuthorizationfilter());//所有的控制器所有的行为都会应用到这个身份验证
            filters.Add(new Myexceptionfileter());

        }
    }
}
