using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class TradesResponse : AnxProResponse
    {
        /// <summary>
        /// List of <see cref="Trade"/>s.
        /// </summary>
        [JsonProperty("trades")]
        public List<Trade> Trades { get; set; }

        /// <summary>
        /// Number of trades returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class Trade
    {
        /// <summary>
        /// Trade id.
        /// </summary>
        [JsonProperty("tradeId")]
        public string TradeId { get; set; }

        /// <summary>
        /// Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>
        /// Order id (uuid).
        /// </summary>
        [JsonProperty("orderId")]
        public Guid OrderId { get; set; }

        /// <summary>
        /// Fill amount.
        /// </summary>
        [JsonProperty("tradedCurrencyFillAmount")]
        public decimal TradedCurrencyFillAmount { get; set; }

        /// <summary>
        /// Fill amount.
        /// </summary>
        [JsonProperty("settlementCurrencyFillAmount")]
        public decimal SettlementCurrencyFillAmount { get; set; }

        /// <summary>
        /// Fill amount.
        /// </summary>
        [JsonProperty("settlementCurrencyFillAmountUnrounded")]
        public decimal SettlementCurrencyFillAmountUnrounded { get; set; }

        /// <summary>
        /// Price.
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Trade pair.
        /// </summary>
        /// <example>BTCJPY</example>
        [JsonProperty("ccyPair")]
        public string CcyPair { get; set; }

        /// <summary>
        /// BUY or SELL.
        /// </summary>
        [JsonProperty("side")]
        public string Side { get; set; }
    }
}
