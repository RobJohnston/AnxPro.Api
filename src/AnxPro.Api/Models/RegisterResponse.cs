using System;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class AutoRegisterResponse : AnxProResponse
    {
        /// <summary>
        /// User's uuid.
        /// </summary>
        [JsonProperty("userUuid")]
        public Guid UserUuid { get; set; }

        /// <summary>
        /// User's username.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
