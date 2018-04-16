using System;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    // User can setup alert when the platform will notify user by email once the price reached.
    public partial class AnxProClient
    {
        /// <summary>
        /// This endpoint allows user to create alert for certain price of certain currency pair.
        /// </summary>
        /// <param name="ccyPair">Currency pair.</param>
        /// <param name="limitPrice">Limited Price.</param>
        /// <param name="type">Raising or falling.</param>
        /// <returns></returns>
        public async Task<AlertResponse> CreateAlertAsync(string ccyPair, decimal limitPrice, AlertType type)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This endpoint allows user to delete alert of certain currency pair.
        /// </summary>
        /// <param name="uuid">Uuid of the alert.</param>
        /// <returns>ResultCode OK</returns>
        public async Task<string> DeleteAlertAsync(Guid uuid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This endpoint allows user to get a list of alert previous set up.
        /// </summary>
        /// <returns></returns>
        public async Task<AlertsResponse> GetAlertsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
