﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace OdeToFood
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddTransient<IGreeter, Greeter>();  // Lazy creation, create instance when needed
            services.AddScoped<IGreeter, Greeter>(); // Create a instance per http request.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
                              IHostingEnvironment env,
                              //IConfiguration configuration,
                              IGreeter greeter,
                              ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(next => {
                // middleware, run once when start up
                return async context => {
                    logger.LogInformation("Request incoming");
                    if (context.Request.Path.StartsWithSegments("/start")) {
                        await context.Response.WriteAsync("Hit!!");
                        logger.LogInformation("Request handled");
                    } else {
                        await next(context);
                        logger.LogInformation("Request outgoing");
                    }
                };
            });

            app.UseWelcomePage(new WelcomePageOptions {
                Path = "/pathPattern"
            });

            app.Run(async (context) =>
            {
                var greeting = greeter.GetMessage();
                await context.Response.WriteAsync(greeting);
            });
        }
    }
}