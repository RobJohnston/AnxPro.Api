using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class CheckAddressResponse : AnxProResponse
    {
        /// <summary>
        /// A boolean flag indicating if a wallet is hosted on ANX platforms or not.
        /// </summary>
        [JsonProperty("exists")]
        public bool Exists { get; set; }
    }
}
