using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace SmartPower.Pages
{
    public class Index_Tests : SmartPowerWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
