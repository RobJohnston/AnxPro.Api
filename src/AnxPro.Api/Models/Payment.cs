using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class Payment
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("externalReference")]
        public string ExternalReference { get; set; }
    }
}
