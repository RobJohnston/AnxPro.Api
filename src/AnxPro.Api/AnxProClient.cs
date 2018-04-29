using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AnxPro.Api
{
    public partial class AnxProClient : IDisposable
    {
        private string _key;
        private string _secret;
        private string _url;
        private string _version;
        private Guid _userUuid = Guid.Empty;

        private static readonly CultureInfo _culture = CultureInfo.InvariantCulture;
        private readonly HttpClient _httpClient = new HttpClient();

        internal static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() }
        };

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AnxProClient"/> class for calling public functions.
        /// </summary>
        public AnxProClient()
        {
            _url = "https://anxpro.com/api";
            _version = "3";
            _httpClient.BaseAddress = new Uri(string.Format("{0}/{1}/", _url, _version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnxProClient"/> class for calling private functions.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="apiSecret">The API secret.</param>
        public AnxProClient(string apiKey, string apiSecret) : this()
        {
            _key = apiKey ?? "";
            _secret = apiSecret ?? "";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnxProClient"/> class for calling private functions.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="apiSecret">The API secret.</param>
        /// <param name="userUuid">For the request from "Master" API, you should need to add "userUuid" property with value of uuid if the user that you like to continue.</param>
        public AnxProClient(string apiKey, string apiSecret, Guid userUuid) : this(apiKey, apiSecret)
        {
            _userUuid = userUuid;
        }

        #endregion

        /// <summary>
        /// Sends a public GET request to the AnxPro API as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T">Type of data contained in the response.</typeparam>
        /// <param name="requestUrl">The relative URL the request is sent to.</param>
        /// <param name="args">Optional arguments passed as querystring parameters.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <remarks>The <paramref name="requestUrl"/> is relative to https://anxpro.com/api/3/. </remarks>
        /// <exception cref="ArgumentNullException"><paramref name="requestUrl"/> is <c>null</c>.</exception>
        /// <exception cref="HttpRequestException">There was a problem with the HTTP request.</exception>
        public async Task<T> QueryPublicAsync<T>(string requestUrl, Dictionary<string, string> args = null)
        {
            if (requestUrl == null)
                throw new ArgumentNullException(nameof(requestUrl));

            args = args ?? new Dictionary<string, string>(0);

            // Setup request.
            var urlEncodedArgs = UrlEncode(args);

            var req = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_httpClient.BaseAddress, string.Format("{0}?{1}", requestUrl, urlEncodedArgs))
            };

            // Send request and deserialize response.
            return await SendRequestAsync<T>(req).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends a private POST request to the AnxPro API as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T">Type of data contained in the response.</typeparam>
        /// <param name="requestUrl">The relative URL the request is sent to.</param>
        /// <param name="args">Optional arguments passed as form data.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <remarks>The <paramref name="requestUrl"/> is relative to https://anxpro.com/api/3/. </remarks>
        /// <exception cref="ArgumentNullException"><paramref name="requestUrl"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentNullException">Api key is <c>null</c>. Do you use the correct constructor?</exception>
        /// <exception cref="HttpRequestException">There was a problem with the HTTP request.</exception>
        public async Task<T> QueryPrivateAsync<T>(string requestUrl, Dictionary<string, string> args = null)
        {
            if (requestUrl == null)
                throw new ArgumentNullException(nameof(requestUrl));

            //if (string.IsNullOrWhiteSpace(_key))
            //    throw new SignatureException("The API key cannot be null.");

            //if (string.IsNullOrWhiteSpace(_secret))
            //    throw new SignatureException("The API secret cannot be null.");

            // Add 3 additional args.
            args = args ?? new Dictionary<string, string>(3);

            string nonce = null;

            if (GetNonce != null)
            {
                nonce = (await GetNonce().ConfigureAwait(false)).ToString(_culture);
                args["nonce"] = nonce;
            }

            if (_userUuid != Guid.Empty)
            {
                args["userUuid"] = _userUuid.ToString();
            }

            // Setup request.
            var jsonEncodedArgs = JsonEncode(args);
            var address = string.Format("api/{0}/{1}", _version, requestUrl);

            //var test = GenerateApiSignature("7pgj8Dm6", "Test", "Message");
            var signature = GenerateApiSignature(_secret, address, jsonEncodedArgs);

            var req = new HttpRequestMessage(HttpMethod.Post, requestUrl)
            {
                Content = new StringContent(jsonEncodedArgs, Encoding.UTF8, "application/json")
            };

            req.Headers.Add("rest-key",_key);
            req.Headers.Add("rest-sign", signature);

            // Send request and deserialize response.
            return await SendRequestAsync<T>(req).ConfigureAwait(false);
        }

        public async Task<T> QueryPrivateUnsignedAsync<T>(string requestUrl, Dictionary<string, string> args = null)
        {
            //TODO: Implement for the /apiKey, /register/verifyRegistration, and /register/resendVerification endpoints.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources used by the
        /// underlying <see cref="HttpClient"/>.
        /// </summary>
        public void Dispose() => _httpClient.Dispose();

        #region Private methods

        /// <summary>
        /// The signature is an HMAC hash constructed from your API secret, your API method path, your post data, and uses the SHA-512 algorithm.
        /// </summary>
        private string GenerateApiSignature(string secret, string path, string data)
        {
            string signature;
            var secretBytes = Convert.FromBase64String(secret);
            var input = path + '\0' + data;

            using (var stream = new MemoryStream(Encoding.ASCII.GetBytes(input)))
            {
                using (var hmacsha512 = new HMACSHA512(secretBytes))
                {
                    var hashData = hmacsha512.ComputeHash(stream);
                    signature = Convert.ToBase64String(hashData);
                }
            }

            return signature;
        }

        /// <summary>
        /// Gets or sets the getter function for a nonce (default = <c>DateTime.UtcNow.Ticks</c>).
        /// <para>API expects a unique value for each request.</para>
        /// </summary>
        private Func<Task<long>> GetNonce { get; set; } = () => Task.FromResult(DateTime.UtcNow.Ticks);

        private async Task<T> SendRequestAsync<T>(HttpRequestMessage req)
        {
            var reqCtx = new RequestContext
            {
                HttpRequest = req
            };

            // Perform the HTTP request.
            var res = await _httpClient.SendAsync(reqCtx.HttpRequest).ConfigureAwait(false);

            Debug.WriteLine(req);
            Debug.WriteLine(res);

            var resCtx = new ResponseContext
            {
                HttpResponse = res
            };

            // Throw for HTTP-level error.
            resCtx.HttpResponse.EnsureSuccessStatusCode();

            // Get the response.
            var jsonContent = await resCtx.HttpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
            Debug.WriteLine(jsonContent);
            
            // Deserialize the response.
            var response = JsonConvert.DeserializeObject<T>(jsonContent, JsonSettings);

            return response;
        }

        private static string JsonEncode(Dictionary<string, string> args)
        {
            return JsonConvert.SerializeObject(args);
        }

        private static string UrlEncode(Dictionary<string, string> args) => string.Join(
            "&",
            args.Where(x => x.Value != null).Select(x => x.Key + "=" + WebUtility.UrlEncode(x.Value))
        );

        #endregion
    }
}
