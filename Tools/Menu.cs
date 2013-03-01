using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace RepairCustomerDatabase.Tools
{
    public static class Menu
    {
        //http://stackoverflow.com/questions/2844866/asp-net-mvc-create-dynamic-navigation-sub-menu-on-the-master-page
        public static MvcHtmlString RenderMenu(this HtmlHelper html)
        {
            var page = Html.ViewContext.HttpContext.Request.RawUrl;

        }
    }
}