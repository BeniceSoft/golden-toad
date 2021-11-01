using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BeniceSoft.GoldenToad.Web
{
    [Dependency(ReplaceServices = true)]
    public class GoldenToadBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "GoldenToad";
    }
}
