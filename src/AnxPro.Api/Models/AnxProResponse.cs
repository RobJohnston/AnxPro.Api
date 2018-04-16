using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class AnxProResponse
    {
        /// <summary>
        /// UNIX timestamp in milliseconds.
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>
        /// Result code reflecting the success status of the operation.
        /// </summary>
        /// <remarks>
        [JsonProperty("resultCode")]
        public string ResultCode { get; set; }
    }
}
