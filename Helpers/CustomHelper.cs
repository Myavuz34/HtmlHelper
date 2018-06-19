using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVC_033_CustomHelper.Helpers
{
    public static class CustomHelper
    {
        public static MvcHtmlString Textbox(string id, string name = "")
        {
            if (string.IsNullOrEmpty(name))
                name = id;
            string inputHtml = string.Format("<input type='text' id='{0}' name='{1}'/>", id, name);
            MvcHtmlString textbox=MvcHtmlString.Create(inputHtml);
            return textbox;
        }
        public static MvcHtmlString Textbox2(this HtmlHelper htmlHelperlHelper,string id, string name ,string cssClassName)
        {
            if (string.IsNullOrEmpty(name))
                name = id;
            string inputHtml = string.Format("<input type='text' id='{0}' name='{1}' class='{2}' />", id, name,cssClassName);
            MvcHtmlString textbox = MvcHtmlString.Create(inputHtml);
            return textbox;
        }
    }
}