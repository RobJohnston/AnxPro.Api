using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {
        /// <summary>
        /// Validate coin address.
        /// </summary>
        /// <param name="ccy">Digital currency supported by site. E.g., BTC, LTC, XRP, ETH.</param>
        /// <param name="address">Address in the selected <paramref name="ccy"/>.</param>
        /// <remarks>
        /// Before sending out digital currencies, this service could validate if the address is valid.
        /// </remarks>
        /// <returns>
        /// <c>ResultCode</c> OK or INVALID_PARAMETERS
        /// </returns>
        public async Task<ValidateAddressResponse> ValidateAddressAsync(string ccy, string address)
        {
            return await QueryPrivateAsync<ValidateAddressResponse>(
                "validateAddress",
                new Dictionary<string, string>(2)
                {
                    ["ccy"] = ccy,
                    ["address"] = address,
                }
            );
        }

        /// <summary>
        /// This endpoint allows you to check by digital asset public address if a digital asset wallet is hosted on ANX platforms.
        /// </summary>
        /// <param name="ccy">Digital asset official accronym.</param>
        /// <param name="address">Public address of digital asset.</param>
        /// <remarks>
        /// Note that this endpoint is only enabled for a limited list of users (usually site owners). 
        /// Please reachout to ANX (http://anxintl.com/contact-us/) if you want this endpoint enabled for you.
        /// </remarks>
        /// <returns></returns>
        public async Task<CheckAddressResponse> CheckAddressAsync(string ccy, string address)
        {
            throw new NotImplementedException();
        }
    }
}
