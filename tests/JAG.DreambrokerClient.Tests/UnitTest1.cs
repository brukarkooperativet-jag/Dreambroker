using System;
using System.Linq;
using Xunit;

namespace JAG.Dreambroker.Tests
{
    public class UnitTest1
    {
        Uri jsonUrlForInstructionVideosOnDreambrokerPublicWebsite = new Uri("https://dreambroker.com/channel/ij7bmvur.json");
        [Fact]
        public async void Test1()
        {
            int numberOfVideosInFeedOn_10th_June_2020 = 120;
            var response = await DreambrokerClient.GetFeedDataAsync(jsonUrlForInstructionVideosOnDreambrokerPublicWebsite)
                .ConfigureAwait(false);

            Assert.Equal(numberOfVideosInFeedOn_10th_June_2020, response.Items.Count());
        }
    }
}
