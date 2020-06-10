using System;
using System.Linq;
using Xunit;

namespace JAG.Dreambroker.Tests
{
    public class DreambrokerClientTests
    {
        private readonly Uri _jsonUrlForInstructionVideosOnDreambrokerPublicWebsite = new Uri("https://dreambroker.com/channel/ij7bmvur.json");

        [Fact]
        public async void NumberOfVideosInFeedMatchNumberOfVideosAsOf10thJune2020()
        {
            int numberOfVideosInFeedOn_10th_June_2020 = 120;
            var response = await DreambrokerClient.GetFeedDataAsync(_jsonUrlForInstructionVideosOnDreambrokerPublicWebsite)
                .ConfigureAwait(false);

            Assert.Equal(numberOfVideosInFeedOn_10th_June_2020, response.Items.Count());
        }

        [Fact]
        public async void EmptyUriThrowsArgumentNullException()
        {
            Uri emptyUri = null;

            await Assert.ThrowsAsync<ArgumentNullException>(() =>
                DreambrokerClient.GetFeedDataAsync(emptyUri)).ConfigureAwait(false);
        }
    }
}
