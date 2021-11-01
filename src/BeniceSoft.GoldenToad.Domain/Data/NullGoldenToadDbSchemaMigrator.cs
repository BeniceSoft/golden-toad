using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BeniceSoft.GoldenToad.Data
{
    /* This is used if database provider does't define
     * IGoldenToadDbSchemaMigrator implementation.
     */
    public class NullGoldenToadDbSchemaMigrator : IGoldenToadDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}