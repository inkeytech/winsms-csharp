/* 
 * WINSMS
 *
 * WinSMS RESTful API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@winsms.co.za
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShortcodeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a list of incoming short/long code messages 
        /// </summary>
        /// <remarks>
        /// ***Only available to users with a [WinSMS Short/Long Code](https://support.winsms.co.za/winsms-long-short-code-system/).*** Get a list of all incoming short/long code messages received by the account.  Only the first 100 incoming short/long code messages will be returned if no ***offset*** and ***limit*** parameters are specified. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  (optional, default to 0)</param>
        /// <param name="limit">***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  (optional, default to 100)</param>
        /// <returns>ShortcodeMessageResponse</returns>
        ShortcodeMessageResponse GetShortCodeMessages (int? offset = null, int? limit = null);

        /// <summary>
        /// Get a list of incoming short/long code messages 
        /// </summary>
        /// <remarks>
        /// ***Only available to users with a [WinSMS Short/Long Code](https://support.winsms.co.za/winsms-long-short-code-system/).*** Get a list of all incoming short/long code messages received by the account.  Only the first 100 incoming short/long code messages will be returned if no ***offset*** and ***limit*** parameters are specified. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  (optional, default to 0)</param>
        /// <param name="limit">***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  (optional, default to 100)</param>
        /// <returns>ApiResponse of ShortcodeMessageResponse</returns>
        ApiResponse<ShortcodeMessageResponse> GetShortCodeMessagesWithHttpInfo (int? offset = null, int? limit = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a list of incoming short/long code messages 
        /// </summary>
        /// <remarks>
        /// ***Only available to users with a [WinSMS Short/Long Code](https://support.winsms.co.za/winsms-long-short-code-system/).*** Get a list of all incoming short/long code messages received by the account.  Only the first 100 incoming short/long code messages will be returned if no ***offset*** and ***limit*** parameters are specified. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  (optional, default to 0)</param>
        /// <param name="limit">***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  (optional, default to 100)</param>
        /// <returns>Task of ShortcodeMessageResponse</returns>
        System.Threading.Tasks.Task<ShortcodeMessageResponse> GetShortCodeMessagesAsync (int? offset = null, int? limit = null);

        /// <summary>
        /// Get a list of incoming short/long code messages 
        /// </summary>
        /// <remarks>
        /// ***Only available to users with a [WinSMS Short/Long Code](https://support.winsms.co.za/winsms-long-short-code-system/).*** Get a list of all incoming short/long code messages received by the account.  Only the first 100 incoming short/long code messages will be returned if no ***offset*** and ***limit*** parameters are specified. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  (optional, default to 0)</param>
        /// <param name="limit">***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ShortcodeMessageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShortcodeMessageResponse>> GetShortCodeMessagesAsyncWithHttpInfo (int? offset = null, int? limit = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ShortcodeApi : IShortcodeApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShortcodeApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortcodeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShortcodeApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get a list of incoming short/long code messages  ***Only available to users with a [WinSMS Short/Long Code](https://support.winsms.co.za/winsms-long-short-code-system/).*** Get a list of all incoming short/long code messages received by the account.  Only the first 100 incoming short/long code messages will be returned if no ***offset*** and ***limit*** parameters are specified. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  (optional, default to 0)</param>
        /// <param name="limit">***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  (optional, default to 100)</param>
        /// <returns>ShortcodeMessageResponse</returns>
        public ShortcodeMessageResponse GetShortCodeMessages (int? offset = null, int? limit = null)
        {
             ApiResponse<ShortcodeMessageResponse> localVarResponse = GetShortCodeMessagesWithHttpInfo(offset, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of incoming short/long code messages  ***Only available to users with a [WinSMS Short/Long Code](https://support.winsms.co.za/winsms-long-short-code-system/).*** Get a list of all incoming short/long code messages received by the account.  Only the first 100 incoming short/long code messages will be returned if no ***offset*** and ***limit*** parameters are specified. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  (optional, default to 0)</param>
        /// <param name="limit">***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  (optional, default to 100)</param>
        /// <returns>ApiResponse of ShortcodeMessageResponse</returns>
        public ApiResponse< ShortcodeMessageResponse > GetShortCodeMessagesWithHttpInfo (int? offset = null, int? limit = null)
        {

            var localVarPath = "/shortcode/incoming";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (APIKeyHeader) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("AUTHORIZATION")))
            {
                localVarHeaderParams["AUTHORIZATION"] = this.Configuration.GetApiKeyWithPrefix("AUTHORIZATION");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetShortCodeMessages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ShortcodeMessageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShortcodeMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShortcodeMessageResponse)));
        }

        /// <summary>
        /// Get a list of incoming short/long code messages  ***Only available to users with a [WinSMS Short/Long Code](https://support.winsms.co.za/winsms-long-short-code-system/).*** Get a list of all incoming short/long code messages received by the account.  Only the first 100 incoming short/long code messages will be returned if no ***offset*** and ***limit*** parameters are specified. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  (optional, default to 0)</param>
        /// <param name="limit">***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  (optional, default to 100)</param>
        /// <returns>Task of ShortcodeMessageResponse</returns>
        public async System.Threading.Tasks.Task<ShortcodeMessageResponse> GetShortCodeMessagesAsync (int? offset = null, int? limit = null)
        {
             ApiResponse<ShortcodeMessageResponse> localVarResponse = await GetShortCodeMessagesAsyncWithHttpInfo(offset, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of incoming short/long code messages  ***Only available to users with a [WinSMS Short/Long Code](https://support.winsms.co.za/winsms-long-short-code-system/).*** Get a list of all incoming short/long code messages received by the account.  Only the first 100 incoming short/long code messages will be returned if no ***offset*** and ***limit*** parameters are specified. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="offset">***Optional*** - The number of items to skip before starting to return results. Default 0. Minimum 0.  (optional, default to 0)</param>
        /// <param name="limit">***Optional*** - The number of items to return. Default 100. Minimum 1. Maximum 1000.  (optional, default to 100)</param>
        /// <returns>Task of ApiResponse (ShortcodeMessageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ShortcodeMessageResponse>> GetShortCodeMessagesAsyncWithHttpInfo (int? offset = null, int? limit = null)
        {

            var localVarPath = "/shortcode/incoming";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (offset != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (APIKeyHeader) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("AUTHORIZATION")))
            {
                localVarHeaderParams["AUTHORIZATION"] = this.Configuration.GetApiKeyWithPrefix("AUTHORIZATION");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetShortCodeMessages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ShortcodeMessageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ShortcodeMessageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ShortcodeMessageResponse)));
        }

    }
}
