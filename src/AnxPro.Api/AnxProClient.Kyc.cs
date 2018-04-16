using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    // User can applied KYC Application so one can trade and increase limit of withdrawal and deposit.
    // 
    // /kyc/document needs to be called afterward in order to upload the document correctly. It is suggested to get the kyc document in UI first.
    public partial class AnxProClient
    {
        public async Task<VerifyPersonalCommand> UploadKycPersonalInfo()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This endpoint allows user to upload document for KYC application. 
        /// </summary>
        /// <param name="uuid"><c>Uuid</c> of reponse from <see cref="UploadKycPersonalInfo"/>.</param>
        /// <param name="file1">Supported document 1. (id document, selfie with id document, or address proof within last 3 month)</param>
        /// <param name="file2">Supported document 2. (optional if file size limit permitted)</param>
        /// <param name="file3">Supported document 3. (optional if file size limit permitted)</param>
        /// <remarks>
        /// <para>
        /// This need to be called right after <see cref="UploadKycPersonalInfo"/>. It is suggested to get the kyc document in UI first.
        /// </para>
        /// <para>
        /// This api can be called multiple times as long as the application has not been processed.
        /// </para>
        /// <para>
        /// The limit is 10MB
        /// </para>
        /// </remarks>
        /// <returns></returns>
        public async Task<AnxProResponse> UploadKycDocuments(Guid uuid, byte[] file1, byte[] file2, byte[] file3)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This endpoint allows user to get status of one's KYC application.
        /// </summary>
        /// <returns></returns>
        public async Task GetKycStatus()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This endpoint allows user to submit verification code that recieved from ANX to complete KYC application.
        /// </summary>
        /// <param name="verificationCode">Verification code from ANX.</param>
        /// <returns></returns>
        public async Task<AnxProResponse> VerifyKycCode(string verificationCode)
        {
            throw new NotImplementedException();
        }
    }
}
