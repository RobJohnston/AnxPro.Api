namespace AnxPro.Api.Models
{
    public enum ErrorCode
    {
        /// <summary>
        /// Can not found corresponding order.
        /// </summary>
        ORDER_NOT_FOUND,

        /// <summary>
        /// Cancel request submiited.
        /// </summary>
        CANCEL_REQUEST_SUBMITTED,

        /// <summary>
        /// Order cannot be cancel.
        /// </summary>
        ORDER_CANCEL_WRONG_STATE
    }
}
