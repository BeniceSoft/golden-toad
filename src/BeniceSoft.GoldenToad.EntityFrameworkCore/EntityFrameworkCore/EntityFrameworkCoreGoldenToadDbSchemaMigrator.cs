using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BeniceSoft.GoldenToad.Data;
using Volo.Abp.DependencyInjection;

namespace BeniceSoft.GoldenToad.EntityFrameworkCore
{
    public class EntityFrameworkCoreGoldenToadDbSchemaMigrator
        : IGoldenToadDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreGoldenToadDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the GoldenToadDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<GoldenToadDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
