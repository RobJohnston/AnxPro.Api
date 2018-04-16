using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public partial class ValidateAddressResponse : AnxProResponse
    {
        /// <summary>
        /// Requested address.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Requested currency.
        /// </summary>
        /// <example>BTC, LTC, XRP, ETH</example>
        [JsonProperty("ccy")]
        public string Ccy { get; set; }

        /// <summary>
        /// A true/false value stating if the address is valid.
        /// </summary>
        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }
}
