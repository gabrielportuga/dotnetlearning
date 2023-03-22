using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oasTools.domain
{
    public class Language
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; } = 0;

        [JsonProperty(PropertyName = "language_code")]
        public string language_code { get; set; } = "";

        [JsonProperty(PropertyName = "language_name")]
        public string language_name { get; set; } = "";

        public List<Dealer> dealers { get; set; } = new List<Dealer>();
    }
}