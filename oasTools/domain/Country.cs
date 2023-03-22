using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oasTools.domain
{
    public class Country
    {
        [Key]
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; } = 0;

        [JsonProperty(PropertyName = "country_code")]
        public string country_code { get; set; } = "";

        [JsonProperty(PropertyName = "country_name")]
        public string country_name { get; set; } = "";

        public List<Language> languages { get; set; } = new List<Language>();
    }
}