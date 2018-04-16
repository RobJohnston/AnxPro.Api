using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class CancelOrderResponse : AnxProResponse
    {
        /// <summary>
        /// List of <see cref="CancelStatus"/>.
        /// </summary>
        [JsonProperty("resultCodeList")]
        public List<CancelStatus> ResultCodeList { get; set; }

        public class CancelStatus
        {
            /// <summary>
            /// Order's uuid.
            /// </summary>
            [JsonProperty("uuid")]
            public Guid Uuid { get; set; }

            /// <summary>
            /// Error code.
            /// </summary>
            [JsonProperty("errorCode")]
            public ErrorCode ErrorCode { get; set; }
        }
    }
}
