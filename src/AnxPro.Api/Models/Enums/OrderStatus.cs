namespace AnxPro.Api.Models
{
    public enum OrderStatus
    {
        /// <summary>
        /// This order is newly created.
        /// </summary>
        DRAFT,

        /// <summary>
        /// Pending to be processed by the system.
        /// </summary>
        PENDING_SUBMISSION,

        /// <summary>
        /// Active. Pending to be matched by the system.
        /// </summary>
        ACTIVE,

        /// <summary>
        /// Expired.
        /// </summary>
        EXPIRED,

        /// <summary>
        /// Partially filled.
        /// </summary>
        PARTIAL_FILL,

        /// <summary>
        /// Full filled.
        /// </summary>
        FULL_FILL,

        /// <summary>
        /// Not filled.
        /// </summary>
        NO_FILL,

        /// <summary>
        /// This order is cancelled due to the user's account doesn't have enough traded currency or settlement currency to fund this trade.
        /// </summary>
        CANCEL_UNFUNDED,

        /// <summary>
        /// This order is canceled by user.
        /// </summary>
        USER_CANCEL,

        /// <summary>
        /// This order is canceled.
        /// </summary>
        CANCELLED,

        /// <summary>
        /// This order is suspended.
        /// </summary>
        SUSPENDED,

        /// <summary>
        /// This order is cancelled by user; and before the order was cancelled, it was partially filled.
        /// </summary>
        USER_CANCEL_PARTIAL,

        /// <summary>
        /// This order is cancelled when it's outstanding amount is below tradable minimum amount.
        /// </summary>
        CANCEL_TOO_SMALL,

        /// <summary>
        /// This order is replaced by another order.
        /// </summary>
        REPLACED,

        /// <summary>
        /// This order is replaced by another order; and before the order was replaced, it was partially filled.
        /// </summary>
        REPLACED_PARTIAL,

        /// <summary>
        /// This order is not successfully replaced, due to <c>replaceOnlyIfActive</c> flag is set to true and the order is not active when replacing.
        /// </summary>
        CANCELLED_REPLACE_FAILED
    }
}
