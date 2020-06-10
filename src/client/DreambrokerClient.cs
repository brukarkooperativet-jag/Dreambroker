using JAG.Dreambroker.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace JAG.Dreambroker
{
    public class DreambrokerClient
    {
        public async Task GetFeedDataAsync(string url)
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync(url);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception();

            var result = await responseMessage.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<JsonResponse>(result);

            var x = data.Items.First();
        }
    }
}
