using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class QuoteResponseDefinition : AnxProResponse
    {
        [JsonProperty("quoteResponse")]
        public QuoteResponse QuoteResponse { get; set; }
    }

    public class QuoteResponse
    {
        [JsonProperty("responseCode")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// True for buy or false for sell.
        /// </summary>
        [JsonProperty("buyTradedCurrency")]
        public bool BuyTradedCurrency { get; set; }

        /// <summary>
        /// Traded currency.
        /// </summary>
        /// <example>BTC</example>
        [JsonProperty("tradedCurrency")]
        public string TradedCurrency { get; set; }

        /// <summary>
        /// Settlement currency
        /// </summary>
        /// <example>USD</example>
        [JsonProperty("settlementCurrency")]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// Quoted settlement currency amount.
        /// </summary>
        [JsonProperty("quotedSettlementCurrencyAmount")]
        public decimal QuotedSettlementCurrencyAmount { get; set; }

        /// <summary>
        /// Quoted traded currency amount.
        /// </summary>
        [JsonProperty("quotedTradedCurrencyAmount")]
        public decimal QuotedTradedCurrencyAmount { get; set; }

        /// <summary>
        /// Quoted amount to deliver.
        /// </summary>
        [JsonProperty("quotedAmountToDeliver")]
        public decimal QuotedAmountToDeliver { get; set; }

        /// <summary>
        /// Wholesale rate in settlement currency.
        /// </summary>
        [JsonProperty("wholesaleRateInSettlementCurrency")]
        public decimal WholesaleRateInSettlementCurrency { get; set; }

        /// <summary>
        /// Retail rate in settlement currency.
        /// </summary>
        [JsonProperty("retailRateInSettlementCurrency")]
        public decimal RetailRateInSettlementCurrency { get; set; }

        /// <summary>
        /// Customer reference.
        /// </summary>
        [JsonProperty("customRef")]
        public string CustomRef { get; set; }

        /// <summary>
        /// Quote id.
        /// </summary>
        [JsonProperty("quoteId")]
        public string QuoteId { get; set; }

        /// <summary>
        /// Timestamp which the quote is expired at.
        /// </summary>
        [JsonProperty("quoteExpiresAt")]
        public long QuoteExpiresAt { get; set; }

        /// <summary>
        /// Timestamp which the quote is created at.
        /// </summary>
        [JsonProperty("quoteCreatedAt")]
        public long QuoteCreatedAt { get; set; }

        /// <summary>
        /// Max amount.
        /// </summary>
        [JsonProperty("maxAmount")]
        public decimal MaxAmount { get; set; }
    }
}
