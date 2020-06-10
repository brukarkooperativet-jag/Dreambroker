using Newtonsoft.Json;

namespace JAG.Dreambroker.Models
{
    public class CategoryItem
    {
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }
    }
}
