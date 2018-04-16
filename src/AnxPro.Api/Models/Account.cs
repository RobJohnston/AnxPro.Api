using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class Account
    {
        /// <summary>
        /// UNIX timestamp in milliseconds.
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        /// <summary>
        /// Result code reflecting the success status of the operation.
        /// </summary>
        [JsonProperty("resultCode")]
        public string ResultCode { get; set; }

        /// <summary>
        /// Info result.
        /// </summary>
        [JsonProperty("data")]
        public InfoResult Data { get; set; }

        /// <summary>
        /// User's uuid.
        /// </summary>
        [JsonProperty("userUuid")]
        public Guid UserUuid { get; set; }

        public class InfoResult
        {
            /// <summary>
            /// Created date in format (yyyy-MM-dd HH:mm:ss)
            /// </summary>
            public string Created { get; set; }

            /// <summary>
            /// User's prefered language.
            /// </summary>
            /// <example>en_US</example>
            public string Language { get; set; }

            /// <summary>
            /// Username.
            /// </summary>
            public string Login { get; set; }

            /// <summary>
            /// Ordering fee.
            /// </summary>
            public string Trade_Fee { get; set; }

            /// <summary>
            /// List of access right.
            /// </summary>
            /// <example>["trade", "withdraw", "get_info" ]</example>
            public List<string> Rights { get; set; }

            /// <summary>
            /// Map of ccy and wallet.
            /// </summary>
            public Dictionary<string, Wallet> Wallets { get; set; }

            public class Wallet
            {
                /// <summary>
                /// Balance.
                /// </summary>
                public Amount Balance { get; set; }

                /// <summary>
                /// Available balance.
                /// </summary>
                public Amount Available_Balance { get; set; }

                /// <summary>
                /// Withdrawal limit for the past 24 hours.
                /// </summary>
                public Amount Daily_Withdrawal_Limit { get; set; }

                /// <summary>
                /// Max withdrawal limit.
                /// </summary>
                public Amount Max_Withdraw { get; set; }

                public class Amount
                {
                    /// <summary>
                    /// Display in short.
                    /// </summary>
                    /// <example>199.99 BTC</example>
                    [JsonProperty("displayShort")]
                    public string DisplayShort { get; set; }

                    /// <summary>
                    /// Value in Integer.
                    /// </summary>
                    /// <example>19999400000</example>
                    [JsonProperty("valueInt")]
                    public string ValueInt { get; set; }

                    /// <summary>
                    /// Currency.
                    /// </summary>
                    /// <example>BTC</example>
                    [JsonProperty("currency")]
                    public string Currency { get; set; }

                    /// <summary>
                    /// Display in full.
                    /// </summary>
                    /// <example>199.99400000 BTC</example>
                    [JsonProperty("display")]
                    public string Display { get; set; }

                    /// <summary>
                    /// Value.
                    /// </summary>
                    /// <example>199.99400000</example>
                    [JsonProperty("value")]
                    public string Value { get; set; }
                }
            }
        }
    }
}
