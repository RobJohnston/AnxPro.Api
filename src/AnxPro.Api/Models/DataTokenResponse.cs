using System;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class DataTokenResponse : AnxProResponse
    {
        /// <summary>
        /// Data token.
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// User's uuid.
        /// </summary>
        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }
    }
}
