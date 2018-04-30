using Newtonsoft.Json;

namespace AnxPro.Api.Models.ApiV2
{
    public class Ticker
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("data")]
        public TickerData Data { get; set; }

        public class TickerData
        {
            /// <summary>
            /// 24 hrs high.
            /// </summary>
            [JsonProperty("high")]
            public Detail High { get; set; }

            /// <summary>
            /// 24 hrs low.
            /// </summary>
            [JsonProperty("low")]
            public Detail Low { get; set; }

            /// <summary>
            /// 24 hrs average.
            /// </summary>
            [JsonProperty("avg")]
            public Detail Avg { get; set; }

            /// <summary>
            /// 24 hrs vwap.
            /// </summary>
            [JsonProperty("vwap")]
            public Detail Vwap { get; set; }

            /// <summary>
            /// 24 hrs volume.
            /// </summary>
            [JsonProperty("vol")]
            public Detail Vol { get; set; }

            /// <summary>
            /// Last price.
            /// </summary>
            [JsonProperty("last")]
            public Detail Last { get; set; }

            /// <summary>
            /// Top order on the bid queue.
            /// </summary>
            [JsonProperty("buy")]
            public Detail Buy { get; set; }

            /// <summary>
            /// Top order on the ask queue.
            /// </summary>
            [JsonProperty("sell")]
            public Detail Sell { get; set; }

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

            public class Detail
            {
                [JsonProperty("display_short")]
                public string DisplayShort { get; set; }

                [JsonProperty("value_int")]
                public long ValueInt { get; set; }

                [JsonProperty("currency")]
                public string Currency { get; set; }

                [JsonProperty("display")]
                public string Display { get; set; }

                [JsonProperty("value")]
                public decimal Value { get; set; }
            }
        }
    }
}
