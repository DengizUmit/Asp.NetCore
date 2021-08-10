using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Middlewares
{
    public class ResponseEditingMiddleware
    {
        private RequestDelegate _requestDelegate;

        public ResponseEditingMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await _requestDelegate.Invoke(httpContext);
            if (httpContext.Response.StatusCode == StatusCodes.Status404NotFound)
                await httpContext.Response.WriteAsync("Page Not Found");
        }
    }
}
