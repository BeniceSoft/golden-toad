using BeniceSoft.GoldenToad.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BeniceSoft.GoldenToad
{
    [DependsOn(
        typeof(GoldenToadEntityFrameworkCoreTestModule)
        )]
    public class GoldenToadDomainTestModule : AbpModule
    {

    }
}