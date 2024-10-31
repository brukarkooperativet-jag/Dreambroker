using JAG.Dreambroker.Models;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace JAG.Dreambroker
{
    public static class DreambrokerClient
    {
        private static readonly HttpClient httpClient = new();

        /// <summary>
        /// Fetch the current rss stream for a Dreambroker channel.
        /// </summary>
        /// <param name="url">Full url for a channel rss stream in Dreambroker</param>
        /// <param name="cancellationToken">Pass a cancellation token if there is a need to be able to cancel the request.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public static async Task<DreamBrokerResponse> GetFeedDataAsync(Uri url, CancellationToken cancellationToken = default)
        {
            if (url == null)
                throw new ArgumentNullException(nameof(url), "The url parameter must not be null.");

            try
            {
                var responseMessage = await httpClient.GetAsync(url, cancellationToken);
                responseMessage.EnsureSuccessStatusCode();

                var result = await responseMessage.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<DreamBrokerResponse>(result) 
                    ?? throw new InvalidOperationException("Failed to deserialize response.");
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException($"Request to {url} failed: {e.Message}", e);
            }
            catch (JsonException e)
            {
                throw new InvalidOperationException($"Failed to deserialize JSON response from {url}: {e.Message}", e);
            }
        }
    }
}
