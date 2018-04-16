namespace AnxPro.Api.Models
{
    public enum VerifyRequestState
    {
        /// <summary>
        /// Verification is draft mode.
        /// </summary>
        DRAFT,

        /// <summary>
        /// Verification is uploaded.
        /// </summary>
        PRE_SUBMIT,

        /// <summary>
        /// Verification waiting for approval.
        /// </summary>
        SUBMITTED,

        /// <summary>
        /// Verification approved.
        /// </summary>
        PROCESSED_APPROVED,

        /// <summary>
        /// Verification rejected.
        /// </summary>
        PROCESSED_REJECTED
    }
}
