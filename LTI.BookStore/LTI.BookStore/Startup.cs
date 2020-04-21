using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LTI.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            /*
            app.Use(async (context,next)=>
            {
                await context.Response.WriteAsync("Hello from first middleware");
                await next();
                await context.Response.WriteAsync("Hello from f irst middleware response");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from second middleware");
                await next();
                await context.Response.WriteAsync("Hello from second middleware response");
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from third middleware");
                await next();
            });
            */
            //map the url to a particular resource
            // if we comment the below routing code Map and MapGet method will throw exception
            // app.routing must be placed before anny endpoint routing.
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // mapping url to a particular resource
                //MapGet only handle get request for this particular route
                //endpoints.MapGet("/", async context => 

                //Map will handle all the request to this particular route
                /*
                 endpoints.Map("/", async context => 
                 {
                     await context.Response.WriteAsync("Hello World!");
                 });
                 */

                //endpoint for MVC route
                endpoints.MapDefaultControllerRoute();
            });

            /*
            //Custom Route
            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/lti", async context =>
                {
                    await context.Response.WriteAsync("Hello LTI!");
                });
            });
            */
        }
    }
}
  