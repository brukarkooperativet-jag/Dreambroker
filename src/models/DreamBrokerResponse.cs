using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JAG.Dreambroker.Models
{
    public class DreamBrokerResponse
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("link")]
        public string Link { get; set; }
        [JsonPropertyName("videoWidth")]
        public int VideoWidth { get; set; }
        [JsonPropertyName("videoHeight")]
        public int VideoHeight { get; set; }
        [JsonPropertyName("thumbnailWidth")]
        public int ThumbnailWidth { get; set; }
        [JsonPropertyName("thumbnailHeight")]
        public int ThumbnailHeight { get; set; }
        [JsonPropertyName("categories")]
        public IEnumerable<CategoryItem> Categories { get; set; }
        [JsonPropertyName("items")]
        public IEnumerable<ContentItem> Items { get; set; }
    }
}
