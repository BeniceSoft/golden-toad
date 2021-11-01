using Volo.Abp.Modularity;

namespace BeniceSoft.GoldenToad
{
    [DependsOn(
        typeof(GoldenToadApplicationModule),
        typeof(GoldenToadDomainTestModule)
        )]
    public class GoldenToadApplicationTestModule : AbpModule
    {

    }
}