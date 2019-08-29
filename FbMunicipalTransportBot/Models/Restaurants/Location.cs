using Newtonsoft.Json;

namespace FbMunicipalTransportBot.Models.Restaurants
{
    public class Location
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("locality")]
        public string Locality { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
    }
}