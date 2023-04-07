using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OasTools.domain
{
    public class Vendor
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; } = 0;

        [JsonProperty(PropertyName = "vendor_name")]
        public string vendor_name { get; set; } = "";

        public List<Market> markets { get; set; } = new List<Market>();
    }
}