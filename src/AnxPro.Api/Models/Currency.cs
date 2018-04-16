using Newtonsoft.Json;

namespace AnxPro.Api.Models
{
    public class Currency
    {
        /// <summary>
        /// Decimal place used for trading.
        /// </summary>
        [JsonProperty("decimals")]
        public long Decimals { get; set; }

        /// <summary>
        /// Minimum order size.
        /// </summary>
        [JsonProperty("minOrderSize")]
        public double MinOrderSize { get; set; }

        /// <summary>
        /// Maximum order size.
        /// </summary>
        [JsonProperty("maxOrderSize")]
        public long MaxOrderSize { get; set; }

        /// <summary>
        /// Minimum order value.
        /// </summary>
        [JsonProperty("minOrderValue")]
        public double MinOrderValue { get; set; }

        /// <summary>
        /// Maximum order value.
        /// </summary>
        [JsonProperty("maxOrderValue")]
        public long MaxOrderValue { get; set; }

        /// <summary>
        /// Maximum market order value.
        /// </summary>
        [JsonProperty("maxMarketOrderValue")]
        public long MaxMarketOrderValue { get; set; }

        /// <summary>
        /// Maximum market order size.
        /// </summary>
        [JsonProperty("maxMarketOrderSize")]
        public long MaxMarketOrderSize { get; set; }

        /// <summary>
        /// Display denominator.
        /// </summary>
        /// <example>1000</example>
        [JsonProperty("displayDenominator")]
        public double DisplayDenominator { get; set; }

        /// <summary>
        /// Decimals place used to display summary.
        /// </summary>
        /// <example>0</example>
        [JsonProperty("summaryDecimals")]
        public long SummaryDecimals { get; set; }

        /// <summary>
        /// Currency unit.
        /// </summary>
        /// <example>kDOGE</example>
        [JsonProperty("displayUnit")]
        public string DisplayUnit { get; set; }

        /// <summary>
        /// Symbol of the currency.
        /// </summary>
        /// <example>Ɖ for DODGE</example>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// CRYPTO or FIAT.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("confirmationThresholds")]
        public ConfirmationThreshold[] ConfirmationThresholds { get; set; }

        /// <summary>
        /// Standard network fee.
        /// </summary>
        /// <example>0.00010000</example>
        [JsonProperty("networkFee")]
        public double? NetworkFee { get; set; }

        /// <summary>
        /// <see cref="FundEnglineSettings"/>.
        /// </summary>
        [JsonProperty("engineSettings")]
        public FundEnglineSettings EngineSettings { get; set; }

        /// <summary>
        /// Url prefix to handle the relatd coin address.
        /// </summary>
        /// <example>bitcoin:</example>
        [JsonProperty("urlPrefix")]
        public string UrlPrefix { get; set; }

        /// <summary>
        /// SATOSHI, COLORED_COIN_OPEN_ASSETS, MULTICHAIN, MULTICHAIN_NATIVE, RIPPLE, RIPPLE_IOU, ETHEREUM, ETHEREUM_TOKEN.
        /// </summary>
        [JsonProperty("digitalCurrencyType")]
        public DigitalCurrencyType? DigitalCurrencyType { get; set; }

        /// <summary>
        /// (CRYPTO type only)
        /// </summary>
        [JsonProperty("assetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// (CRYPTO type only)
        /// </summary>
        /// <example>ANX</example>
        [JsonProperty("assetName")]
        public string AssetName { get; set; }

        /// <summary>
        /// (CRYPTO type only) Asset divisibility.
        /// </summary>
        /// <example>2</example>
        [JsonProperty("assetDivisibility")]
        public long AssetDivisibility { get; set; }

        /// <summary>
        /// (CRYPTO type only) Asset icon.
        /// </summary>
        [JsonProperty("assetIcon")]
        public string AssetIcon { get; set; }

        /// <summary>
        /// (CRYPTO type only) Asset issue quantity.
        /// </summary>
        /// <example>10000</example>
        [JsonProperty("assetIssueQuantity")]
        public string AssetIssueQuantity { get; set; }

        public class FundEnglineSettings
        {
            /// <summary>
            /// True if deposits enabled.
            /// </summary>
            [JsonProperty("depositsEnabled")]
            public bool DepositsEnabled { get; set; }

            /// <summary>
            /// True if withdrawals enabled.
            /// </summary>
            [JsonProperty("withdrawalsEnabled")]
            public bool WithdrawalsEnabled { get; set; }

            /// <summary>
            /// True if display enabled. The app should hide the currency to respect the platform.
            /// </summary>
            [JsonProperty("displayEnabled")]
            public bool DisplayEnabled { get; set; }

            /// <summary>
            /// True always from API v3.
            /// </summary>
            [JsonProperty("mobileAccessEnabled")]
            public bool MobileAccessEnabled { get; set; }
        }

        public class ConfirmationThreshold
        {
            [JsonProperty("confosRequired")]
            public long ConfosRequired { get; set; }

            [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
            public decimal? Threshold { get; set; }
        }
    }
}
