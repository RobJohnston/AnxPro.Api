using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class TransactionResponse : AnxProResponse
    {
        /// <summary>
        /// List of <see cref="Transaction"/>s.
        /// </summary>
        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }

        /// <summary>
        /// Number of transactions returned.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        public class Transaction
        {
            /// <summary>
            /// FILL, COUPON and etc.
            /// </summary>
            [JsonProperty("transactionClas")]
            public string TransactionClas { get; set; }

            /// <summary>
            /// Uuid of the transaction.
            /// </summary>
            /// <example>6d568392-ce9f-42b9-bfe6-074cffa78d6b</example>
            [JsonProperty("uuid")]
            public Guid Uuid { get; set; }

            /// <summary>
            /// Uuid belong to the user.
            /// </summary>
            /// <example>67271c1d -2f9b-48e2- a5bb-01c8a8ce11a4</example>
            [JsonProperty("userUuid")]
            public Guid UserUuid { get; set; }

            /// <summary>
            /// Total amount of the transaction.
            /// </summary>
            /// <example>-1.00345678</example>
            [JsonProperty("amount")]
            public decimal Amount { get; set; }

            /// <summary>
            /// Fee included in the transaction.
            /// </summary>
            /// <example>0.0</example>
            [JsonProperty("fee")]
            public decimal Fee { get; set; }

            /// <summary>
            /// Balance before the transaction.
            /// </summary>
            /// <example>105337.05233524</example>
            [JsonProperty("balanceBefore")]
            public decimal BalanceBefore { get; set; }

            /// <summary>
            /// Balance after the transaction.
            /// </summary>
            /// <example>105336.04887846</example>
            [JsonProperty("balanceAfter")]
            public decimal BalanceAfter { get; set; }

            /// <summary>
            /// Account currency.
            /// </summary>
            /// <example>BTC</example>
            [JsonProperty("ccy")]
            public string Ccy { get; set; }

            /// <summary>
            /// Transaction state.
            /// </summary>
            /// <example>PROCESSED</example>
            [JsonProperty("transactionState")]
            public TransactionState TransactionState { get; set; }

            /// <summary>
            /// Transaction type.
            /// </summary>
            /// <example>FILL_DEBIT</example>
            [JsonProperty("transactionType")]
            public string TransactionType { get; set; }

            /// <summary>
            /// Recieved timestamp.
            /// </summary>
            /// <example>1431004151000</example>
            [JsonProperty("received")]
            public long Received { get; set; }

            /// <summary>
            /// Processed timestamp.
            /// </summary>
            /// <example>1431004151000</example>
            [JsonProperty("processed")]
            public long Processed { get; set; }

            /// <summary>
            /// Created timestamp.
            /// </summary>
            /// <example>1464677126478</example>
            [JsonProperty("timestampMillis")]
            public long TimestampMillis { get; set; }

            /// <summary>
            /// Order Fill.
            /// </summary>
            [JsonProperty("displayTitle")]
            public string DisplayTitle { get; set; }

            /// <summary>
            /// Sell BTC @ 3231.23333 HKD / BTC.
            /// </summary>
            [JsonProperty("displayDescription")]
            public string DisplayDescription { get; set; }
        }
    }
}
