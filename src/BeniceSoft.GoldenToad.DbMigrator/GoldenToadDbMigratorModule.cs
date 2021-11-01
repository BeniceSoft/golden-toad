using BeniceSoft.GoldenToad.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BeniceSoft.GoldenToad.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(GoldenToadEntityFrameworkCoreModule),
        typeof(GoldenToadApplicationContractsModule)
        )]
    public class GoldenToadDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
