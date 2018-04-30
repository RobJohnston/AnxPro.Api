using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnxPro.Api.Models.ApiV2
{
    public class OrderBook
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("data")]
        public OrderBookData Data { get; set; }

        public class OrderBookData
        {
            /// <summary>
            /// Unix timestamp, in microsecond.
            /// </summary>
            [JsonProperty("now")]
            public long Now { get; set; }

            /// <summary>
            /// Unix timestamp, in microsecond.
            /// </summary>
            [JsonProperty("dataUpdateTime")]
            public long DataUpdateTime { get; set; }

            [JsonProperty("asks")]
            public List<OrderBookDetail> Asks { get; set; }

            [JsonProperty("bids")]
            public List<OrderBookDetail> Bids { get; set; }

            public class OrderBookDetail
            {
                [JsonProperty("price")]
                public decimal Price { get; set; }

                [JsonProperty("price_int")]
                public long PriceInt { get; set; }

                [JsonProperty("amount")]
                public decimal Amount { get; set; }

                [JsonProperty("amount_int")]
                public long AmountInt { get; set; }
            }
        }
    }
}
