using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace RiskFirstTests
{
    public class AddressTest
    {
        [Fact]
        public async Task TestGetByCity()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/address/london");

                response.EnsureSuccessStatusCode();

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
