using System;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class SubAccountResponse : AnxProResponse
    {
        /// <summary>
        /// UUID of the subAccount newly created.
        /// </summary>
        [JsonProperty("subAccount")]
        public Guid SubAccount { get; set; } 
    }
}
