using System;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {
        /// <summary>
        /// Send bitcoin/altcoin to a crypto-currency address.
        /// </summary>
        /// <param name="ccy">Currency (currently one of BTC, LTC, DOGE, XRP, STR).</param>
        /// <param name="address">Valid address in the selected <c>ccy</c>.</param>
        /// <param name="otp">OTP key for security reason.</param>
        /// <param name="amount">Amount to send (must be less than the available balance).</param>
        /// <param name="destinationTag">Destination tag facilitate identifying the purpose of payments and allow a single address to be utilized by multiple users.
        /// Additionally, these tags enable the return of payments. (This parameter only use for crypto currency with <c>distinationTag</c> such as Ripple).
        /// </param>
        /// <remarks>
        /// <para>This services allow support crypto send operations. The API Key must have "move funds" authority, which is configured on the web site.</para>
        /// 
        /// <para>Please note that a confirmation email would be sent to you to confirm this withdrawal. 
        /// If you do not click the confirmation link on the email, the withdrawal will be reversed after 10 minutes. 
        /// If you would like this feature disabled on your account, you can visit our site and create a Express Withdrawal setting. 
        /// Express Withdrawal allows you to perform withdrawal without the need of 2-factor authentication or response to our email confirmation as soon as the total value of the transactions is smaller than the daily limit you defined. 
        /// The transactions are evaluated against your favourite settlement currency available in our site.
        /// Should you have any questions, please contact service@anxpro.com.</para>
        /// </remarks>
        /// <returns>
        /// <c>ResultCode:</c> OK or INVALID_PARAMETERS.
        /// </returns>
        public async Task<SendResponse> SendAsync(string ccy, string address, string otp, decimal amount, string destinationTag = "")
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtain a current receive address for the given token.
        /// </summary>
        /// <param name="ccy">Traded currency (currently one of BTC, LTC, DOGE, XRP and STR).</param>
        /// <param name="subAccount">Uuid of the subAccount of which you want to get coin address. If not specified, this will be your default subAccount.</param>
        /// <remarks>
        /// Use this service to obtain a valid address to recieve crypto funds.
        /// </remarks>
        /// <returns></returns>
        public async Task<ReceiveResponse> ReceiveAsync(string ccy, Guid? subAccount)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a new receive address for the given token.
        /// </summary>
        /// <param name="ccy">Traded currency (currently one of BTC, LTC, DOGE, XRP and STR).</param>
        /// <param name="subAccount">Uuid of subAccount for which you want to create a new coin address. If not specified, this will be your default subAccount.</param>
        /// <remarks>
        /// Use this service to create a new address to recieve crypto funds. 
        /// New address will be created only the specified sub-account has received at least one account. 
        /// Note that each account has a max number of sub-accounts, contact support to increase this limit.
        /// </remarks>
        /// <returns></returns>
        public async Task<ReceiveResponse> CreateReceiveAddressAsync(string ccy, Guid? subAccount)
        {
            throw new NotImplementedException();
        }
    }
}
