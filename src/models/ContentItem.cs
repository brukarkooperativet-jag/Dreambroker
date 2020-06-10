using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace JAG.Dreambroker.Models
{
    public class ContentItem
    {
        [JsonProperty("guid")]
        public string Guid { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("pubDate")]
        public string PubDate { get; set; }
        [JsonProperty("pubDateUTC")]
        public string PubDateUTC { get; set; }
        [JsonProperty("pubDateTimestamp")]
        public long PubDateTimestamp { get; set; }
        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }
        [JsonProperty("modifiedDateUTC")]
        public string ModifiedDateUTC { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        [JsonProperty("order")]
        public string Order { get; set; }
        [JsonProperty("duration")]
        public string Duration { get; set; }
        [JsonProperty("player")]
        public string Player { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
        [JsonProperty("poster")]
        public string Poster { get; set; }
        [JsonProperty("views")]
        public string Views { get; set; }
    }
}
