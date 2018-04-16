using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class SendResponse : AnxProResponse
    {
        /// <summary>
        /// Internal transaction id of the transaction.
        /// </summary>
        /// <remarks>
        /// Note this is not the Bitcoin/crypto coin txid. At the time this method is invoked, the blockchain TXID is not available. 
        /// This identifier, however, can be used to match up the transaction updates send through the push data services.
        /// </remarks>
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }
}
