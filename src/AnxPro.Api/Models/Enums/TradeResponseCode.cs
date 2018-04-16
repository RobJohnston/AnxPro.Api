namespace AnxPro.Api.Models
{
    public enum TradeResponseCode
    {
        INVALID_QUOTE_ID,
        QUOTE_EXPIRED,
        EXECUTED,
        INSUFFICIENT_FUND,
        ENGINE_NOT_AVAILABLE,
        INSUFFICIENT_LIQUIDITY,
        DISCOUNT_CODE_NOT_VALID,
        DAILY_LIMIT_EXCEEDED,
        PENDING_EXECUTE,
        MERCHANT_NOT_AVAILABLE
    }
}
