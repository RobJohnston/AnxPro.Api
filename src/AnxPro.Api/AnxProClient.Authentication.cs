using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {
        /// <summary>
        /// Obtain an API Key.
        /// </summary>
        /// <param name="username">Email address of the registered account.</param>
        /// <param name="password">Password of the registered account.</param>
        /// <param name="allowMoveFund">True if the api key allow to move fund.</param>
        /// <param name="deviceId">Unique identifying string for the calling client/ device. Note that subsequent calls with the same deviceId will reset the secret key - so this cannot be shared across multiple devices.</param>
        /// <param name="otp">OTP key if the user has OTP enabled</param>
        /// <remarks>
        /// This service creates a new API Key, or resets the secret key on an existing API Key.
        /// Unlike other requests, this request is not signed with an API key, rather the user's credentials are posted in the request.
        /// </remarks>
        /// <returns></returns>
        public async Task<ApiKeyResponse> GetApiKeyAsync(string username, string password, bool allowMoveFund, string deviceId, string otp = "")
        {
            return await QueryPrivateUnsignedAsync<ApiKeyResponse>(
                "apiKey",
                new Dictionary<string, string>(5)
                {
                    ["username"] = username,
                    ["password"] = password,
                    ["otp"] = otp,
                    ["allowMoveFund"] = allowMoveFund ? "1" : "0",
                    ["deviceId"] = deviceId,
                }
            );
        }

        /// <summary>
        /// Create or update an api key for a user.
        /// </summary>
        /// <param name="deviceId">Name of api key.  E.g., apiKey1.</param>
        /// <param name="allowMoveFund">True if user can withdraw fiat or crypto.</param>
        /// <param name="placeOrders">True if user can trade.</param>
        /// <remarks>Only allow if the authorized api key is the master key.</remarks>
        /// <returns></returns>
        public async Task<ApiKeyResponse> CreateApiKeyAsync(string deviceId, bool allowMoveFund, bool placeOrders)
        {
            return await QueryPrivateUnsignedAsync<ApiKeyResponse>(
                "apiKey/create",
                new Dictionary<string, string>(4)
                {
                    ["deviceId"] = deviceId,
                    ["allowMoveFund"] = allowMoveFund ? "1" : "0",
                    ["placeOrders"] = placeOrders ? "1" : "0",
                }
            );
        }

        /// <summary>
        /// Obtain an data token for access to data push services.
        /// </summary>
        /// <remarks>
        /// Use this service to obtain a data token and uuid for access to data push services. Firebase is currently supported.
        /// The token expires after 24 hours - client software should regularly check the validity of it's token, and 
        /// use this service to obtain a fresh one when required.
        /// </remarks>
        /// <returns></returns>
        public async Task<DataTokenResponse> GetDataTokenAsync()
        {
            return await QueryPrivateUnsignedAsync<DataTokenResponse>(
                "apiKey/create",
                null
            );
        }
    }
}
