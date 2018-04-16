using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class CurrencyPair
    {
        /// <summary>
        /// Decimals place of price for trading.
        /// </summary>
        [JsonProperty("priceDecimals")]
        public long PriceDecimals { get; set; }

        /// <summary>
        /// <see cref="OrderEngineSettings"/>.
        /// </summary>
        [JsonProperty("engineSettings")]
        public OrderEngineSettings EngineSettings { get; set; }

        /// <summary>
        /// Minmium order rate.
        /// </summary>
        [JsonProperty("minOrderRate")]
        public long MinOrderRate { get; set; }

        /// <summary>
        /// Maxmium order rate.
        /// </summary>
        [JsonProperty("maxOrderRate")]
        public long MaxOrderRate { get; set; }

        /// <summary>
        /// Decimals place of price for display.
        /// </summary>
        [JsonProperty("displayPriceDecimals")]
        public long DisplayPriceDecimals { get; set; }

        /// <summary>
        /// Traded Ccy.
        /// </summary>
        /// <example>BTC for BTCUSD</example>
        [JsonProperty("tradedCcy")]
        public string TradedCcy { get; set; }

        /// <summary>
        /// Settlement Ccy.
        /// </summary>
        /// <example>USD for BTCUSD</example>
        [JsonProperty("settlementCcy")]
        public string SettlementCcy { get; set; }

        /// <summary>
        /// ANX, BITFINEX, BTCE, EGDMARKET, RIPPLE.
        /// </summary>
        [JsonProperty("preferredMarket")]
        public PreferredMarket PreferredMarket { get; set; }

        //[JsonProperty("chartEnabled")]
        //public bool ChartEnabled { get; set; }

        //[JsonProperty("simpleTradeEnabled")]
        //public bool SimpleTradeEnabled { get; set; }

        public class OrderEngineSettings
        {
            /// <summary>
            /// True if trading enabled.
            /// </summary>
            [JsonProperty("tradingEnabled")]
            public bool TradingEnabled { get; set; }

            /// <summary>
            /// True if display enabled.
            /// </summary>
            [JsonProperty("displayEnabled")]
            public bool DisplayEnabled { get; set; }

            /// <summary>
            /// Cancel.
            /// </summary>
            [JsonProperty("cancelOnly")]
            public bool CancelOnly { get; set; }

            /// <summary>
            /// True if verification required for trading.
            /// </summary>
            [JsonProperty("verifyRequired")]
            public bool VerifyRequired { get; set; }

            /// <summary>
            /// True if user cannot buy the currency pair.
            /// </summary>
            [JsonProperty("restrictedBuy")]
            public bool RestrictedBuy { get; set; }

            /// <summary>
            /// True if user cannot sell the currency pair.
            /// </summary>
            [JsonProperty("restrictedSell")]
            public bool RestrictedSell { get; set; }
        }
    }
}
