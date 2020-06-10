using Newtonsoft.Json;
using System.Collections.Generic;

namespace JAG.Dreambroker.Models
{
    public class DreamBrokerResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("videoWidth")]
        public int VideoWidth { get; set; }

        [JsonProperty("videoHeight")]
        public int VideoHeight { get; set; }

        [JsonProperty("thumbnailWidth")]
        public int ThumbnailWidth { get; set; }

        [JsonProperty("thumbnailHeight")]
        public int ThumbnailHeight { get; set; }

        [JsonProperty("categories")]
        public IEnumerable<CategoryItem> Categories { get; set; }

        [JsonProperty("items")]
        public IEnumerable<ContentItem> Items { get; set; }
    }
}
