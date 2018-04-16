namespace AnxPro.Api.Models
{
    public enum TransactionState
    {
        /// <summary>
        /// Transaction submitted
        /// </summary>
        SUBMITTED,

        /// <summary>
        /// Transaction has been processed
        /// </summary>
        PROCESSED,

        /// <summary>
        /// Transaction has been suspended
        /// </summary>
        SUSPENDED,

        /// <summary>
        /// Reversed
        /// </summary>
        REVERSED,

        /// <summary>
        /// Limit overrided
        /// </summary>
        LIMIT_OVERRIDE_APPROVED,

        /// <summary>
        /// Cancelled insufficent funds
        /// </summary>
        CANCELLED_INSUFFICIENT_FUNDS,

        /// <summary>
        /// Cancelled - limit breach
        /// </summary>
        CANCELLED_LIMIT_BREACH,

        /// <summary>
        /// Pending confirmation
        /// </summary>
        PENDING_CONFIRM,

        /// <summary>
        /// Pending confirmation
        /// </summary>
        PENDING_SUFFICIENT_CONFIRMATIONS,

        /// <summary>
        /// Pending to reverese
        /// </summary>
        PENDING_REVERSE,

        /// <summary>
        /// Pending limit approval
        /// </summary>
        PENDING_LIMIT_APPROVAL
    }
}
