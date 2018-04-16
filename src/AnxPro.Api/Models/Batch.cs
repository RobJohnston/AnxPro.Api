using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class BatchResponse : AnxProResponse
    {
        /// <summary>
        /// Internal batch id.
        /// </summary>
        [JsonProperty("batchId")]
        public string BatchId { get; set; }
    }

    public class BatchesResponse : AnxProResponse
    {
        /// <summary>
        /// List of <see cref="Batch"/>es.
        /// </summary>
        [JsonProperty("batches")]
        public string Batches { get; set; }
    }

    public class BatchInfoResponse : BatchResponse
    {
        /// <summary>
        /// Withdrawal amount of the batch.
        /// </summary>
        /// <example>1234.12345678</example>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// <see cref="BatchSendState"/>.
        /// </summary>
        [JsonProperty("status")]
        public BatchSendState Status { get; set; }

        /// <summary>
        /// Recieved time stamp (unixtimestamp in millis).
        /// </summary>
        [JsonProperty("submittedTimestamp")]
        public long SubmittedTimestamp { get; set; }

        /// <summary>
        /// List of submitted payments.
        /// </summary>
        [JsonProperty("payments")]
        public List<BatchWithdrawalPayment> Payments { get; set; }

        [JsonProperty("transactions")]
        public List<BatchWithdrawalTransaction> Transactions { get; set; }

        public class BatchWithdrawalPayment
        {
            /// <summary>
            /// Batch received.
            /// </summary>
            [JsonProperty("paymentId")]
            public string PaymentId { get; set; }

            /// <summary>
            /// Withdrawal amount.
            /// </summary>
            [JsonProperty("amount")]
            public decimal Amount { get; set; }

            /// <summary>
            /// Withdrawal address.
            /// </summary>
            [JsonProperty("address")]
            public string Address { get; set; }

            /// <summary>
            /// External reference Id.
            /// </summary>
            [JsonProperty("externalReference")]
            public string ExternalReference { get; set; }
        }

        public class BatchWithdrawalTransaction
        {
            /// <summary>
            /// Transaction id.
            /// </summary>
            [JsonProperty("transactionId")]
            public string TransactionId { get; set; }

            /// <summary>
            /// Transaction Id on blockchain.
            /// </summary>
            [JsonProperty("blockchainTransactionId")]
            public string BlockchainTransactionId { get; set; }

            /// <summary>
            /// Network fee.
            /// </summary>
            [JsonProperty("networkFee")]
            public decimal NetworkFee { get; set; }

            /// <summary>
            /// Created timestamp.
            /// </summary>
            [JsonProperty("createdTimestamp")]
            public long CreatedTimestamp { get; set; }
        }
    }

    public partial class Batch
    {
        [JsonProperty("batchId")]
        public string BatchId { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("status")]
        public BatchSendState Status { get; set; }

        [JsonProperty("submittedTimestamp")]
        public long SubmittedTimestamp { get; set; }
    }
}
