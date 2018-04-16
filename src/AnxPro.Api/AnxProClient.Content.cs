using System;
using System.Threading.Tasks;
using AnxPro.Api.Models;

namespace AnxPro.Api
{
    public partial class AnxProClient
    {
        /// <summary>
        /// This endpoint retrieve all news from the exchange platform.
        /// </summary>
        /// <param name="locale">Language supported. E.g.,zh_CN, zh_HK,pt_BR,en_US, ja_JP.</param>
        /// <returns></returns>
        public async Task<NewsResponse> GetNews(string locale)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This endpoint retrieve all presses from the exchange platform.
        /// </summary>
        /// <param name="locale">Language supported. E.g.,zh_CN, zh_HK,pt_BR,en_US, ja_JP.</param>
        /// <returns></returns>
        public async Task<NewsResponse> GetPressRelease(string locale)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This endpoint retrieve all announcements from the exchange platform.
        /// </summary>
        /// <param name="locale">Language supported. E.g.,zh_CN, zh_HK,pt_BR,en_US, ja_JP.</param>
        /// <returns></returns>
        public async Task<NewsResponse> GetAnnouncements(string locale)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This endpoint retrieve all apiDocs from the exchange platform.
        /// </summary>
        /// <param name="locale">Language supported. E.g.,zh_CN, zh_HK,pt_BR,en_US, ja_JP.</param>
        /// <returns></returns>
        public async Task<NewsResponse> GetApiDocs(string locale)
        {
            throw new NotImplementedException();
        }
    }
}
