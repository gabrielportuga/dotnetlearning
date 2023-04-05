using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace oasTools.domain
{
    public class Brand
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; } = 0;

        [JsonProperty(PropertyName = "brand_name")]
        public string brand_name { get; set; } = "";
    }
}