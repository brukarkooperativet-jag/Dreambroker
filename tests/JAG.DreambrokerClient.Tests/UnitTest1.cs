using System;
using System.Linq;
using Xunit;

namespace JAG.Dreambroker.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {

            var response = await DreambrokerClient.GetFeedDataAsync("https://dreambroker.com/channel/j14ya0zu.json")
                .ConfigureAwait(false);

            Assert.Equal(8, response.Items.Count());
        }
    }
}
