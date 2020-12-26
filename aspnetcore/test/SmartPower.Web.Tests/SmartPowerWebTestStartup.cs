using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace SmartPower
{
    public class SmartPowerWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<SmartPowerWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}