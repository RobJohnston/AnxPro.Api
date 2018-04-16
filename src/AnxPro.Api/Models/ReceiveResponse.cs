using System;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class ReceiveResponse : AnxProResponse
    {
        /// <summary>
        /// Valid crypto address, currently for any one of BTC, LTC, DOGE, XRP and STR).
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// UUID of the subAccount of which the coin address is tied to.
        /// </summary>
        [JsonProperty("subAccount")]
        public Guid SubAccount { get; set; }
    }
}
