using System;
using Xunit;

namespace JAG.Dreambroker.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var client = new DreambrokerClient();

            await client.GetFeedDataAsync("https://dreambroker.com/channel/j14ya0zu.json");
        }
    }
}
