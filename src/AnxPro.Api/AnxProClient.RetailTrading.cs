using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {
        /// <summary>
        /// Quote the price of a currency pair.
        /// </summary>
        /// <param name="tradedCurrency">Traded currency.</param>
        /// <param name="settlementCurrency">Settlement currency.</param>
        /// <param name="tradedCurrencyAmount">Traded currency amount.</param>
        /// <param name="settlementCurrencyAmount">Settlement currency amount.</param>
        /// <param name="buyTradedCurrency">True for buy currency, false for sell.</param>
        /// <param name="isIndicativeQuote">False for retail quote.</param>
        /// <param name="customRef">Customer reference in uuid format.</param>
        /// <returns></returns>
        public async Task<QuoteResponseDefinition> GetQuoteAsync(string tradedCurrency, string settlementCurrency, 
            decimal tradedCurrencyAmount, decimal settlementCurrencyAmount, 
            bool buyTradedCurrency, bool isIndicativeQuote, Guid customRef)
        {
            return await QueryPrivateAsync<QuoteResponseDefinition>(
                "retail/quote",
                new Dictionary<string, string>(7)
                {
                    ["tradedCurrency"] = tradedCurrency,
                    ["settlementCurrency"] = settlementCurrency,
                    ["tradedCurrencyAmount"] = tradedCurrencyAmount.ToString(_culture),
                    ["settlementCurrencyAmount"] = settlementCurrencyAmount.ToString(_culture),
                    ["buyTradedCurrency"] = buyTradedCurrency ? "1" : "0",
                    ["isIndicativeQuote"] = isIndicativeQuote ? "1" : "0",
                    ["customRef"] = customRef.ToString(),
                }
            );
        }

        /// <summary>
        /// This endpoint to trade order previously quoted.
        /// </summary>
        /// <param name="quoteId">Quote Id.</param>
        /// <param name="customRef">Customer reference.</param>
        /// <param name="amount">Amount in traded currency.</param>
        /// <returns>
        /// <para>Trade Response Code</para>
        /// <list type="bullet">
        /// <item><term>INVALID_QUOTE_ID</term></item>
        /// <item><term>QUOTE_EXPIRED</term></item>
        /// <item><term>EXECUTED</term></item>
        /// <item><term>INSUFFICIENT_FUND</term></item>
        /// <item><term>ENGINE_NOT_AVAILABLE</term></item>
        /// <item><term>INSUFFICIENT_LIQUIDITY</term></item>
        /// <item><term>DISCOUNT_CODE_NOT_VALID</term></item>
        /// <item><term>DAILY_LIMIT_EXCEEDED</term></item>
        /// <item><term>PENDING_EXECUTE</term></item>
        /// <item><term>MERCHANT_NOT_AVAILABLE</term></item>
        /// </list>
        /// </returns>
        public async Task<RetailTradeResponse> TradeAsync(string quoteId, string customRef, decimal amount)
        {
            return await QueryPrivateAsync<RetailTradeResponse>(
                "retail/trade",
                new Dictionary<string, string>(7)
                {
                    ["quoteId"] = quoteId,
                    ["customRef"] = customRef,
                    ["amount"] = amount.ToString(_culture),
                }
            );
        }
    }
}
