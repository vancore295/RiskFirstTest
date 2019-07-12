using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using RiskFirstTest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RiskFirstTests
{
    class TestClientProvider
    {
        public HttpClient Client { get; private set; }

        public TestClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = server.CreateClient();
        }
    }
}
