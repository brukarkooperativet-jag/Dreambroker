using System;
using System.Threading.Tasks;
using System.Linq;
using Xunit;

namespace JAG.Dreambroker.Tests
{
    public class DreambrokerClientTests
    {
        private readonly Uri _jsonUrlForInstructionVideosOnDreambrokerPublicWebsite = new Uri("https://dreambroker.com/channel/ij7bmvur.json");

        [Fact]
        public async Task NumberOfVideosInFeedMatchNumberOfVideosAsOf30thOct2024()
        {
            int numberOfVideosInFeedOn_30th_October_2024 = 121;
            var response = await DreambrokerClient
                .GetFeedDataAsync(_jsonUrlForInstructionVideosOnDreambrokerPublicWebsite);

            Assert.Equal(numberOfVideosInFeedOn_30th_October_2024, response.Items.Count());
        }

        [Fact]
        public async Task EmptyUriThrowsArgumentNullException()
        {
            Uri emptyUri = null;

            await Assert.ThrowsAsync<ArgumentNullException>(() =>
                DreambrokerClient.GetFeedDataAsync(emptyUri));
        }
    }
}
