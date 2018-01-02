using System.IO;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Application;
using WebApi.configuration;
using WebApi.Domain;
using WebApi.Infrastructure;
using WebApi.MiddleWare;

namespace WebApi
{
    public class Startup
    {
        public static IConfigurationRoot Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: false)
                .AddJsonFile("appSettings.{env.EnvironmentName}.json", optional: true)
                .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddOptions();
            //Example
            //services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
            services.Configure<AppSettings>(Configuration);
            services.AddSingleton<IUsersService, UsersService>();
            services.AddSingleton<IUsersRepository, UsersRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }

            // This is same as below, just exposed via an extension method on IApplicationBuilder
            //app.UseMiddleware<PowerDmsMiddleware>();
            app.UsePowerDmsQueryChecker();
            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Oops!");
            });
        }
    }
}
