using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {
        /// <summary>
        /// Send Batch of Blockchain Withdrawals
        /// </summary>
        /// <param name="ccy">Currency (currently one of BTC, LTC, DOGE, XRP, STR).</param>
        /// <param name="amount">Total amount sent in the batch. must equal sumit of payments.</param>
        /// <param name="payments">List of <see cref="Payment"/>s.</param>
        /// <remarks>
        /// <para>
        /// This services allows the submission of large batch withdrawals.
        /// Don't use this method unless you have pre-arranged with ANX support as the withdrawals are manually reconciled and approved.
        /// The batch will be reconciled and submitted in a serious or large transactions.
        /// </para>
        /// <para>
        /// The breakdown of which payments were sent in which blockchain transaction will be return on the <see cref="GetBatch"/> method when is has been executed.
        /// </para>
        /// </remarks>
        /// <returns></returns>
        public async Task<BatchResponse> CreateBatchAsync(string ccy, decimal amount, List<Payment> payments)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Send Batch of Blockchain Withdrawals.
        /// </summary>
        /// <param name="ccy">Currency (currently one of BTC, LTC, DOGE, XRP, STR).</param>
        /// <param name="amount">Total amount sent in the batch. must equal sumit of payments.</param>
        /// <param name="payments">List of <see cref="Payment"/>s.</param>
        /// <remarks>
        /// <para>
        /// This services allows the submission of large batch withdrawals. The payments will be added to an existing pending batch, or a new one.
        /// You should record the batch id return against the payment for future status updates.
        /// </para>
        /// <para>
        /// The breakdown of which payments were sent in which blockchain transaction will be return on the <see cref="GetBatch"/> method when is has been executed.
        /// </para>
        /// </remarks>
        /// <returns>
        /// <c>ResultCode</c>: 
        /// OK, BATCH_NOT_EXIST, BATCH_TOTAL_MISMATCH, BATCH_DUPLICATE_ADDRESS, BATCH_INVALID_ADDRESS
        /// </returns>
        public async Task AddBatchAsync(string ccy, decimal amount, List<Payment> payments)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get list of batches (pending and executed).
        /// </summary>
        /// <param name="max">Max number of results.</param>
        /// <param name="offset">Offset to start at, descending order.</param>
        /// <remarks>This services allows the query of batch statuses.</remarks>
        /// <returns></returns>
        public async Task<BatchesResponse> GetBatchesAsync(int max, int offset)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get detailed info on specific batch.
        /// </summary>
        /// <param name="batchId">Batch Id.</param>
        /// <remarks>This services allows the query of batch details.</remarks>
        /// <returns></returns>
        public async Task<BatchInfoResponse> GetBatchAsync(string batchId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Close batch for send.
        /// </summary>
        /// <param name="batchId">Batch Id.</param>
        /// <returns>
        /// <c>ResponseCode</c>:
        /// OK, BATCH_WRONG_STATE, INSUFFICIENT_AVAILABLE_BALANCE, TOO_SMALL, INSUFFICIENT_LIMIT, SYSTEM_ERROR
        /// </returns>
        public async Task<AnxProResponse> CloseForSendAsync(string batchId)
        {
            throw new NotImplementedException();
        }
    }
}
