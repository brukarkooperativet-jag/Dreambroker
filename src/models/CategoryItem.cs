using System.Text.Json.Serialization;

namespace JAG.Dreambroker.Models
{
    public class CategoryItem
    {
        [JsonPropertyName("categoryId")]
        public string CategoryId { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("level")]
        public int Level { get; set; }
    }
}
