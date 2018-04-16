using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public partial class ApiKeyResponse : AnxProResponse
    {
        /// <summary>
        /// Identifier for the api key, which identifies the user.
        /// </summary>
        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        /// <summary>
        /// Secret key for the api key which is used to sign requests.
        /// This must be secured as it can be used to compromise the user's account.
        /// </summary>
        [JsonProperty("apiSecret")]
        public string ApiSecret { get; set; }

        /// <summary>
        /// User's uuid return by autoRegister.
        /// </summary>
        [JsonProperty("userUuid")]
        public string UserUuid { get; set; }
    }
}
