using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AnxPro.Api.Models.ApiV2;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {
        /// <summary>
        /// Get the most recent ticker for a currency pair.
        /// </summary>
        /// <param name="currencyPair">A currency pair.</param>
        /// <returns></returns>
        /// <remarks>Uses API v2 endpoint.</remarks>
        public async Task<Ticker> GetTicker(string currencyPair)
        {
            return await QueryPublicAsync<Ticker>(
                string.Format("{0}/money/ticker", currencyPair),
                null
            );
        }

        /// <summary>
        /// Get the most recent ticker for a currency pair.
        /// </summary>
        /// <param name="currencyPair">A currency pair.</param>
        /// <param name="extraCcyPairs">Specify a list of extra currency pair to get the results in one go. E.g. extraCcyPairs=LTCJPY,DOGENZD.</param>
        /// <returns></returns>
        /// <remarks>Uses API v2 endpoint.</remarks>
        public async Task<Ticker> GetTicker(string currencyPair, string extraCcyPairs)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a complete copy of ANX’s order book on a particular currency pair.
        /// </summary>
        /// <param name="currencyPair"></param>
        /// <returns></returns>
        /// <remarks>Uses API v2 endpoint.</remarks>
        public async Task<OrderBook> GetOrderBook(string currencyPair)
        {
            return await QueryPublicAsync<OrderBook>(
                string.Format("{0}/money/depth/full", currencyPair),
                null
            );
        }

        /// <summary>
        /// Get a complete copy of ANX’s order book on a particular currency pair.
        /// </summary>
        /// <param name="currencyPair">A currency pair.</param>
        /// <param name="extraCcyPairs">Specify a list of extra currency pair to get the results in one go. E.g. extraCcyPairs=LTCJPY,DOGENZD.</param>
        /// <returns></returns>
        /// <remarks>Uses API v2 endpoint.</remarks>
        public async Task<OrderBook> GetOrderBook(string currencyPair, string extraCcyPairs)
        {
            throw new NotImplementedException();
        }
    }
}
