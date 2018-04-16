using System;
using System.Collections.Generic;
using System.Text;

namespace AnxPro.Api.Models
{
    public enum BatchSendState
    {
        /// <summary>
        /// Batch received.
        /// </summary>
        RECEIVED,

        /// <summary>
        /// Batch to send.
        /// </summary>
        PENDING_SEND,

        /// <summary>
        /// Batch processed.
        /// </summary>
        PROCESSED,

        /// <summary>
        /// Batch cancelled.
        /// </summary>
        CANCELLED,

        /// <summary>
        /// Batch pending to debit.
        /// </summary>
        PENDING_DEBIT,

        /// <summary>
        /// Batch pending to approve by operator.
        /// </summary>
        PENDING_APPROVAL
    }
}
