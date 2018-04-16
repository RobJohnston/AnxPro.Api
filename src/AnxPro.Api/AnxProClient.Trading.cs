using System;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {
        /// <summary>
        /// Create/Replace an order.
        /// </summary>
        /// <param name="order"></param>
        /// <remarks>
        /// <para>
        /// By using this method, you can create an order with different order type. 
        /// In addition, you can replace an existing order by providing additional parameters.
        /// </para>
        /// <para>
        /// * <c>tradedCurrencyAmount</c> and <c>settlementCurrencyAmount</c> is mutually exclusive. You can only specify one.
        /// </para>
        /// </remarks>
        /// <returns>
        /// <para>Possible Result code</para>
        /// <list type="bullet">
        /// <item>
        /// <term>ORDER_REQUEST_SUBMITTED</term>
        /// <description>Order request submitted. It is generally considered a successful response.</description>
        /// </item>
        /// <item>
        /// <term>INSUFFICIENT_AVAILABLE_BALANCE</term>
        /// <description>Insufficient available balance.</description>
        /// </item>
        /// <item>
        /// <term>TOO_MANY_OPEN_ORDERS</term>
        /// <description>Too many open orders.</description>
        /// </item>
        /// <item>
        /// <term>TOO_SMALL</term>
        /// <description>Order value too small.</description>
        /// </item>
        /// <item>
        /// <term>USER_NOT_VERIFIED</term>
        /// <description>User is not verified for trading.</description>
        /// </item>
        /// <item>
        /// <term>INVALID_PARAMETERS</term>
        /// <description>Invalid parameters, including wrong currency pair, order amount/rate too big, too many decimal place, etc.</description>
        /// </item>
        /// </list>
        /// </returns>
        public async Task<OrderResponse> CreateOrderAsync(Order order)
        {
            // REVIEW: Input param "order" is slightly different from existing Order class.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get order status.
        /// </summary>
        /// <param name="orderId">Unique id of this order.</param>
        /// <param name="tonce">Ever increasing integer.</param>
        /// <remarks>
        /// In contrary to v2, which only return filled order, this method return order info of any status.
        /// </remarks>
        /// <returns>
        /// <para>Possible Result code</para>
        /// <list type="bullet">
        /// <item>
        /// <term>ORDER_NOT_FOUND</term>
        /// <description>Order not found.</description>
        /// </item>
        /// </list>
        /// </returns>
        public async Task<Order> GetOrderAsync(string orderId, long tonce)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancel a list of orders.
        /// </summary>
        /// <param name="orderIds">List of order ids.</param>
        /// <returns></returns>
        public async Task<CancelOrderResponse> CancelOrderAsync(string[] orderIds)
        {
            throw new NotImplementedException();
        }
    }
}
