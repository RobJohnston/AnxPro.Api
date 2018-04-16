using System;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {

        /// <summary>
        /// Get account information.
        /// </summary>
        /// <returns></returns>
        public async Task<Account> GetAccountAsync()
        {
            return await QueryPrivateAsync<Account>(
                "account",
                null
            );
        }

        /// <summary>
        /// Create a new sub-account to receive crypto funds for the given token.
        /// </summary>
        /// <param name="ccy">Traded currency (currently one of BTC, LTC, DOGE, XRP and STR).</param>
        /// <param name="customRef">An alias of this subaccount, like "Entertainment Funds".</param>
        /// <remarks>
        /// <para>
        /// Use this endpoint to create a new sub-account. There will be a new crypto address tied to this sub-account to recieve crypto funds.
        /// </para>
        /// <para>
        /// NOTE: please do not name your subaccount as "DEFAULT" or "default", these two key words are reserved.
        /// </para>
        /// </remarks>
        /// <returns></returns>
        public async Task<SubAccountResponse> CreateSubAccountAsync(string ccy, string customRef)
        {
            if (customRef == "DEFAULT" || customRef == "default")
                throw new ArgumentException("(NOTE: please do not name your subaccount as \"DEFAULT\" or \"default\", these two key words are reserved.)");

            throw new NotImplementedException();
        }
    }
}
