using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class NewsResponse : AnxProResponse
    {
        /// <summary>
        /// List of <see cref="News"/>.
        /// </summary>
        [JsonProperty("news")]
        public List<News> News { get; set; }
    }

    public class News
    {
        /// <summary>
        /// News headline.
        /// </summary>
        [JsonProperty("headline")]
        string Headline { get; set; }

        /// <summary>
        /// Body.
        /// </summary>
        [JsonProperty("body")]
        string Body { get; set; }

        /// <summary>
        /// Truncated body.
        /// </summary>
        [JsonProperty("bodyTruncated")]
        string BodyTruncated { get; set; }

        /// <summary>
        /// Timestamp of created time.
        /// </summary>
        [JsonProperty("created")]
        public long Created { get; set; }
    }
}
