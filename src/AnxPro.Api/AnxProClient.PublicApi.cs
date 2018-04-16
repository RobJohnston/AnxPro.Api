using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {
        /// <summary>
        /// Obtain supported currency and currency pair.
        /// </summary>
        /// <remarks>
        /// This endpoint returns a list of supported currencies and currency pairs of the platform.
        /// No Rest-Key and Rest-Sign in HTTP Header.
        /// </remarks>
        /// <example>
        /// anxpro.com supported fiats: USD, HKD, EUR, CAD, AUD, SGD, JPY, GBP, NZD
        /// anxpro.com supported crypto currencies: BTC, LTC, DOGE, STR, XRP
        /// anxpro.com supported currency pairs: BTCUSD,BTCHKD,BTCEUR,BTCCAD,BTCAUD,BTCSGD,BTCJPY,BTCGBP,BTCNZD,
        /// LTCBTC,DOGEBTC,STRBTC,XRPBTC
        /// </example>
        /// <returns></returns>
        public async Task<CurrencyStaticResponse> GetCurrenciesAsync()
        {
            return await QueryPublicAsync<CurrencyStaticResponse>(
                "currencyStatic",
                null
            );
        }
    }
}
