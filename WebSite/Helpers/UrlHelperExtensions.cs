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

            string result;

            if ( null != requestUrl && requestUrl.Port == 11111 )
            {
                result = string.Format("{0}://{1}:{2}{3}",
                    requestUrl.Scheme,
                    requestUrl.Host,
                    requestUrl.Port,
                    VirtualPathUtility.ToAbsolute(virtualPath));
            }
            else
            {
                result = string.Format("{0}://{1}{2}{3}",
                    requestUrl.Scheme,
                    requestUrl.Host,
                    requestUrl.Authority,
                    VirtualPathUtility.ToAbsolute(virtualPath));
            }


            return result;
        }
    }
}