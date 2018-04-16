using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class RetailTradeResponse : AnxProResponse
    {
        [JsonProperty("tradeResponse")]
        public TradeResponse TradeResponse { get; set; }
    }

    public class TradeResponse
    {
        [JsonProperty("responseCode")]
        public TradeResponseCode ResponseCode { get; set; }

        [JsonProperty("tradeId")]
        public string TradeId { get; set; }

        [JsonProperty("quoteId")]
        public string QuoteId { get; set; }
    }
}
