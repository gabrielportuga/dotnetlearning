using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace oasTools.domain
{
    public class Market
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; } = 0;

        [JsonProperty(PropertyName = "flexible_services")]
        public JsonDocument? flexible_services { get; set; }

        [JsonProperty(PropertyName = "pricinh_enabled")]
        public JsonDocument? pricinh_enabled { get; set; }

        [JsonProperty(PropertyName = "pacc_services")]
        public JsonDocument? pacc_services { get; set; }

        [JsonProperty(PropertyName = "cbs_mappings")]
        public JsonDocument? cbs_mappings { get; set; }

        [JsonProperty(PropertyName = "cancel_appm_hours")]
        public int cancel_appm_hours { get; set; } = 0;

        [ForeignKey("vendor_id")]
        public Vendor vendor { get; set; } = new Vendor();

        [ForeignKey("country_id")]
        public Country country { get; set; } = new Country();

        public List<Dealer> dealers { get; set; } = new List<Dealer>();
    }
}