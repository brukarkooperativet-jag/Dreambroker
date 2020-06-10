using Xunit;

namespace JAG.Dreambroker.Tests
{
    public class DreambrokerClientTests
    {
        [Fact]
        public async void Get_feed_data_with_client()
        {
            var client = new DreambrokerClient();

            await client.GetFeedDataAsync("https://dreambroker.com/channel/j14ya0zu.json")
                .ConfigureAwait(false);
        }
    }
}
