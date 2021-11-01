using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace BeniceSoft.GoldenToad
{
    public class GoldenToadWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<GoldenToadWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}