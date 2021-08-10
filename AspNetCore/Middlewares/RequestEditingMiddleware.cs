using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore
{
    public class RequestEditingMiddleware
    {

        private RequestDelegate _requestDelegete;

        public RequestEditingMiddleware(RequestDelegate requestDelegete)
        {
            _requestDelegete = requestDelegete;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.ToString() == "/umit")
                await context.Response.WriteAsync("Hiiiii Umit!!!");
            else
                await _requestDelegete.Invoke(context);
        }
    }
}
