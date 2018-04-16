using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class OrderResponse : AnxProResponse
    {
        /// <summary>
        /// Unique id of this order.
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }
    }

    public class OrdersResponse : AnxProResponse
    {
        /// <summary>
        /// List of <see cref="Order"/>s.
        /// </summary>
        [JsonProperty("orders")]
        public List<Order> Orders { get; set; }

        /// <summary>
        /// Number of orders returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class Order
    {
        /// <summary>
        /// Unique id of this order.
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>
        /// IMMEDIATE_OR_CANCEL, LIMIT, MARKET
        /// </summary>
        [JsonProperty("orderType")]
        public OrderType OrderType { get; set; }

        /// <summary>
        /// Status code of this order.
        /// </summary>
        /// <remarks>ACTIVE</remarks>
        [JsonProperty("orderStatus")]
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Settlement currency.
        /// </summary>
        /// <remarks>All fiat (HKD, USD, etc) or Crypto (BTC)</remarks>
        [JsonProperty("settlementCurrency")]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// Settlement currency amount.
        /// </summary>
        /// <remarks>null / numeric</remarks>
        [JsonProperty("settlementCurrencyAmount")]
        public string SettlementCurrencyAmount { get; set; }

        /// <summary>
        /// Settlement currency amount outstanding.
        /// </summary>
        /// <remarks>null / numeric</remarks>
        [JsonProperty("settlementCurrencyAmountOutstanding")]
        public string SettlementCurrencyAmountOutstanding { get; set; }

        /// <summary>
        /// Traded currency.
        /// </summary>
        /// <remarks>BTC, LTC, DOGE, XRP and STR etc.</remarks>
        [JsonProperty("tradedCurrency")]
        public string TradedCurrency { get; set; }

        /// <summary>
        /// Traded currency amount.
        /// </summary>
        /// <remarks>null / numeric</remarks>
        [JsonProperty("tradedCurrencyAmount")]
        public string TradedCurrencyAmount { get; set; }

        /// <summary>
        /// Traded currency amount outstanding.
        /// </summary>
        /// <remarks>null / numeric</remarks>
        [JsonProperty("tradedCurrencyAmountOutstanding")]
        public string TradedCurrencyAmountOutstanding { get; set; }

        /// <summary>
        /// Buying traded currency or settlement currency.
        /// </summary>
        /// <remarks>true or false</remarks>
        [JsonProperty("buyTradedCurrency")]
        public string BuyTradedCurrency { get; set; }

        /// <summary>
        /// The list of <see cref="Trade"/>.
        /// </summary>
        [JsonProperty("trades")]
        public List<Trade> Trades { get; set; }

        /// <summary>
        /// The order id that this order replaced.
        /// </summary>
        [JsonProperty("replaceExistingOrderId")]
        public string ReplaceExistingOrderId { get; set; }

        /// <summary>
        /// Price in settlement currency, do not specify this when placing a market order.
        /// </summary>
        [JsonProperty("limitPriceInSettlementCurrency")]
        public string LimitPriceInSettlementCurrency { get; set; }
    }
}
