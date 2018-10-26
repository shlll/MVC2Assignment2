using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2Assignment2.Models.ActionFilters
{
    public static class HtmlHelper
    {
        public static IHtmlString BootstrapModalWindow(this HtmlHelper helper)
        {
            var htmlString = "<div><h2>Small Modal</h2></div><button>Open Small Modal</button>";
        }
    }
}