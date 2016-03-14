#region

using System;
using System.Web;
using System.Web.Mvc;

#endregion

namespace WebSite.Helpers
{
    public static class UrlHelperExtensions
    {
        public static string ContentFullPath( this UrlHelper url, string virtualPath )
        {
            Uri requestUrl = url.RequestContext.HttpContext.Request.Url;

            string result = string.Format("{0}://{1}{2}",
                requestUrl.Scheme,
                requestUrl.Authority,
                VirtualPathUtility.ToAbsolute(virtualPath));
            return result;
        }
    }
}