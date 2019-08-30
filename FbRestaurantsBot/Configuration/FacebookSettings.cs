using FbRestaurantsBot.Helpers;
using Newtonsoft.Json;

namespace FbRestaurantsBot.Configuration
{
    [JsonObject(Constants.FacebookSettings)]
    public class FacebookSettings
    {
        [JsonProperty("Secret")]
        public string Secret { get; set; }
        [JsonProperty("VerifyToken")]
        public string VerifyToken { get; set; }
        [JsonProperty("Mode")]
        public string Mode { get; set; }
        [JsonProperty("Object")]
        public string Object { get; set; }
    }
}