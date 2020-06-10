using JAG.Dreambroker.Models;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace JAG.Dreambroker
{
    public static class DreambrokerClient
    {
        public static async Task<DreamBrokerResponse> GetFeedDataAsync(Uri url)
        {
            if (url == null) throw new ArgumentNullException($"{nameof(url)} must not be null.");
            using (var httpClient = new HttpClient())
            {
                var responseMessage = await httpClient.GetAsync(url)
                    .ConfigureAwait(false);
                if (!responseMessage.IsSuccessStatusCode)
                    throw new Exception();

                var result = await responseMessage.Content.ReadAsStringAsync()
                    .ConfigureAwait(false);

                return JsonSerializer.Deserialize<DreamBrokerResponse>(result);
            }
        }
    }
}
