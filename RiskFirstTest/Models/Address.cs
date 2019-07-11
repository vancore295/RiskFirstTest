using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiskFirstTest.Models
{
    public class Address
    {
        [JsonProperty(PropertyName = "firstname")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "lastname")]
        public string Lastname { get; set; }
        [JsonProperty(PropertyName = "streetaddress")]
        public string Streetaddress { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
    }
}
