using System.Collections.Generic;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {
        /// <summary>
        /// Get list of transactions.
        /// </summary>
        /// <param name="ccy">Currency (optional).</param>
        /// <param name="transactionState"><see cref="TransactionState"/>. (optional)</param>
        /// <param name="from">Start time (inclusive) of queries transaction, format should be a number (UNIX timestamp in milliseconds). (optional)</param>
        /// <param name="to">End time (inclusive) of queries transaction, format is same as 'from'. (optional)</param>
        /// <param name="offset">If there is more than 'max' results between the date range you specified, this field is useful for you to get the next 'max' results. (optional)</param>
        /// <param name="max">Max results you want the endpoint to return. Note that it can be no greater than 200. Default value is 50 if not provided. (optional)</param>
        /// <param name="lang"><c>displayTitle</c> and <c>displayDescription</c> for each transaction returned will be in the language specified. Default is "en-US".</param>
        /// <remarks>
        /// <para>
        /// By querying this endpoint, you can get your transactions (max result: 200).
        /// You can specify date range and/or offset so that you can paginate the transactions returned.
        /// </para>
        /// <para>Langauge</para>
        /// <list type="table">
        /// <listheader>
        /// <term>Fields</term><term>Description</term>
        /// </listheader>
        /// <item>
        /// <term>zh-CN</term><term>Simplified Chinese</term>
        /// </item>
        /// <item>
        /// <term>zh-HK</term><term>Traditional Chinese</term>
        /// </item>
        /// <item>
        /// <term>pt-BR</term><term></term>
        /// </item>
        /// <item>
        /// <term>en-US</term>English (US)<term></term>
        /// </item>
        /// <item>
        /// <term>ja-JP</term><term>Japanese</term>
        /// </item>
        /// </list>
        /// </remarks>
        /// <returns></returns>
        public async Task<TransactionResponse> GetTransactionsAsync(string ccy, TransactionState? transactionState, long from, long to, int max = 50, int offset = 0, string lang = "en-US")
        {
            return await QueryPrivateAsync<TransactionResponse>(
                "transaction/list",
                new Dictionary<string, string>(7)
                {
                    ["ccy"] = ccy,
                    ["transactionState"] = transactionState.ToString(),
                    ["from"] = from.ToString(_culture),
                    ["to"] = to.ToString(_culture),
                    ["max"] = max.ToString(_culture),
                    ["offset"] = offset.ToString(_culture),
                    ["lang"] = lang,
                }
            );
        }

        /// <summary>
        /// Get a list of orders.
        /// </summary>
        /// <param name="activeOnly">True if order is active only.</param>
        /// <param name="offset">Offset index. (optional)</param>
        /// <param name="max">Max number of orders to retrieved. (optional)</param>
        /// <remarks>Do not set offset and max for all orders.</remarks>
        /// <returns></returns>
        public async Task<OrdersResponse> GetOrdersAsync(bool? activeOnly = true, int offset = 0, int max = 10)
        {
            var args = new Dictionary<string, string>(3)
            {
                ["offset"] = offset.ToString(_culture),
                ["max"] = max.ToString(_culture),
            };

            if (activeOnly.HasValue)
            {
                args.Add("activeOnly", (activeOnly.Value) ? "1" : "0");
            }

            return await QueryPrivateAsync<OrdersResponse>(
                "order/list",
                args
            );
        }

        /// <summary>
        /// Get trade history list of filled trades.
        /// </summary>
        /// <param name="offset">Offset index.</param>
        /// <param name="max">Max number of orders to retrieved.</param>
        /// <returns></returns>
        public async Task<TradesResponse> GetTradesAsync(int offset = 0, int max = 10)
        {
            return await QueryPrivateAsync<TradesResponse>(
                "trade/list",
                new Dictionary<string, string>(2)
                {
                    ["offset"] = offset.ToString(_culture),
                    ["max"] = max.ToString(_culture),
                }
            );
        }
    }
}
