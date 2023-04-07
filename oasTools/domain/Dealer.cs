using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OasTools.domain
{
    public class Dealer
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; } = 0;

        [JsonProperty(PropertyName = "dealer_search_id")]
        public string dealer_search_id { get; set; } = "";

        [JsonProperty(PropertyName = "dealer_name")]
        public string dealer_name { get; set; } = "";

        [JsonProperty(PropertyName = "booking_engine")]
        public string booking_engine { get; set; } = "";

        [JsonProperty(PropertyName = "time_zone")]
        public string time_zone { get; set; } = "";

        [ForeignKey("market_id")]
        public virtual Market market { get; set; } = new Market();

        [ForeignKey("language_id")]
        public virtual Language language { get; set; } = new Language();

        public virtual List<DealerConfiguration> dealerConfigurations { get; set; } = new List<DealerConfiguration>();
    }
}