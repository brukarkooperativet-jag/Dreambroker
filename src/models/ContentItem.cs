using System.Text.Json.Serialization;

namespace JAG.Dreambroker.Models
{
    public class ContentItem
    {
        [JsonPropertyName("guid")]
        public string Guid { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("pubDate")]
        public string PubDate { get; set; }
        [JsonPropertyName("pubDateUTC")]
        public string PubDateUTC { get; set; }
        [JsonPropertyName("pubDateTimestamp")]
        public long PubDateTimestamp { get; set; }
        [JsonPropertyName("modifiedDate")]
        public string ModifiedDate { get; set; }
        [JsonPropertyName("modifiedDateUTC")]
        public string ModifiedDateUTC { get; set; }
        [JsonPropertyName("link")]
        public string Link { get; set; }
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
        [JsonPropertyName("order")]
        public string Order { get; set; }
        [JsonPropertyName("duration")]
        public string Duration { get; set; }
        [JsonPropertyName("player")]
        public string Player { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("categoryId")]
        public string CategoryId { get; set; }
        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }
        [JsonPropertyName("poster")]
        public string Poster { get; set; }
        [JsonPropertyName("views")]
        public string Views { get; set; }
    }
}
