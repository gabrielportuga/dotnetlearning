

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oasTools.domain
{
    public class Dealer
    {
        [JsonProperty(PropertyName = "vendor_id")]
        public string vendor_id { get; set; } = "0";

        [Key]
        [JsonProperty(PropertyName = "dealer_id")]
        public string dealer_id { get; set; } = "0";

        [JsonProperty(PropertyName = "dealer_name")]
        public string dealer_name { get; set; } = "";

        [JsonProperty(PropertyName = "brand")]
        public string brand { get; set; } = "";

        [JsonProperty(PropertyName = "booking_engine")]
        public string booking_engine { get; set; } = "";

        [JsonProperty(PropertyName = "url")]
        public string? url { get; set; }

        [JsonProperty(PropertyName = "country_code")]
        public string country_code { get; set; } = "";

        [JsonProperty(PropertyName = "language")]
        public string language { get; set; } = "";

        [JsonProperty(PropertyName = "time_zone")]
        public string time_zone { get; set; } = "";

        [JsonProperty(PropertyName = "emails")]
        public string emails { get; set; } = "";

    }
}