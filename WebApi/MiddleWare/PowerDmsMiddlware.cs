using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WebApi.MiddleWare
{
    public class PowerDmsMiddlware
    {
        private readonly RequestDelegate _next;

        public PowerDmsMiddlware(RequestDelegate next)
        {
            _next = next;
        }

        // This is where the logic of the middleware goes
        public Task Invoke(HttpContext context)
        {
            var pdmsQuery = context.Request.Query["powerdms"];
            if (!string.IsNullOrWhiteSpace(pdmsQuery))
            {
                context.Response.WriteAsync("EASTER EGG!"); 
            }
            return _next(context);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class PowerDmsMiddlwareExtensions
    {
        public static IApplicationBuilder UsePowerDmsQueryChecker(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PowerDmsMiddlware>();
        }
    }
}
