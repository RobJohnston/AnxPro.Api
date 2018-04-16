using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class CurrencyStaticResponse : AnxProResponse
    {
        [JsonProperty("currencyStatic")]
        public CurrencyStatic CurrencyStatic { get; set; }
    }

    public class CurrencyStatic
    {
        /// <summary>
        /// Map of ccy and currency settings.
        /// </summary>
        /// <example>BTC</example>
        [JsonProperty("currencies")]
        public Dictionary<string, Currency> Currencies { get; set; }

        /// <summary>
        /// Map of CcyPair and Currency Pair Settings.
        /// </summary>
        /// <example>BTCUSD</example>
        [JsonProperty("currencyPairs")]
        public Dictionary<string, CurrencyPair> CurrencyPairs { get; set; }
    }
}
