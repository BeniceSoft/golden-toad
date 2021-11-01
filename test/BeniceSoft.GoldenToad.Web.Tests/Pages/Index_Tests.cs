using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace BeniceSoft.GoldenToad.Pages
{
    public class Index_Tests : GoldenToadWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
