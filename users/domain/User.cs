

using Newtonsoft.Json;

namespace users.domain
{
    public class User
    {
        [JsonProperty(PropertyName = "id")]
        public Guid id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string email { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   name == user.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name);
        }
    }
}