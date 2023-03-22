using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oasTools.domain
{
    public class DealerConfiguration
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; } = 0;

        [JsonProperty(PropertyName = "url")]
        public string url { get; set; } = "";

        [JsonProperty(PropertyName = "email")]
        public string email { get; set; } = "";

        [JsonProperty(PropertyName = "custom_fields")]
        public string custom_fields { get; set; } = "";

        [ForeignKey("dealer_id")]
        public Dealer dealer { get; set; } = new Dealer();

        [ForeignKey("brand_id")]
        public Brand brand { get; set; } = new Brand();
    }
}