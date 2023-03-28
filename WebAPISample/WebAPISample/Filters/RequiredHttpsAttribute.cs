using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebAPISample.Filters
{
    public class RequiredHttpsAttribute: AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if(actionContext.Request.RequestUri.Scheme != Uri.UriSchemeHttps)
            {
                //acknowledge that the uri is found and give a message to use https instead of http
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Found);
                //actionContext.Response.Content = new StreamContent("<p>use HTTPS instead of HTTP</p>");

                UriBuilder uriBuilder = new UriBuilder(actionContext.Request.RequestUri);
                uriBuilder.Port = 44323;
                uriBuilder.Scheme = Uri.UriSchemeHttps;

                actionContext.Response.Headers.Location = uriBuilder.Uri;
            }
            else
            {
                base.OnAuthorization(actionContext);
            }
        }
    }
}