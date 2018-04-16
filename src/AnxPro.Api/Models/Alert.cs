using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class AlertResponse : AnxProResponse
    {
        /// <summary>
        /// Uuid of the alert.
        /// </summary>
        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }
    }

    public class AlertsResponse : AnxProResponse
    {
        /// <summary>
        /// List of <see cref="Alert"/>s.
        /// </summary>
        [JsonProperty("alerts")]
        public List<Alert> Alerts { get; set; }
    }

    public class Alert
    {
        /// <summary>
        /// Currency pair.
        /// </summary>
        /// <example>BTCUSD</example>
        [JsonProperty("ccyPair")]
        public string CcyPair { get; set; }

        /// <summary>
        /// Limited price.
        /// </summary>
        /// <example>123.1234567</example>
        [JsonProperty("limitPrice")]
        public decimal LimitPrice { get; set; }

        /// <summary>
        /// 'raising' or 'falling'.
        /// </summary>
        [JsonProperty("type")]
        public AlertType Type { get; set; }
    }

}
