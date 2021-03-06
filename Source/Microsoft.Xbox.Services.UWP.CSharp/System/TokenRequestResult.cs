﻿
namespace Microsoft.Xbox.Services.System
{
    using global::System;
    using Windows.System;
    using Windows.Security.Credentials;
    using Windows.Security.Authentication.Web.Core;
    using global::System.Threading.Tasks;
    using global::System.Collections.Generic;
    using global::System.Linq;

    internal class TokenRequestResult
    {
        public WebProviderError ResponseError { get; set; }

        public WebTokenRequestStatus ResponseStatus { get; set; }

        public IDictionary<string, string> Properties { get; set; }

        public WebProviderError ProviderError { get; set; }

        public string Token { get; set; }

        public string WebAccountId { get; set; }

        public TokenRequestResult(WebTokenRequestResult result)
        {
            if (result != null)
            {
                this.ResponseStatus = result.ResponseStatus;
                this.ResponseError = result.ResponseError;

                var responseData = result.ResponseData?.FirstOrDefault();
                if (responseData != null)
                {
                    this.Properties = responseData.Properties;
                    this.ProviderError = responseData.ProviderError;
                    this.Token = responseData.Token;
                    this.WebAccountId = responseData.WebAccount.Id;
                }
            }
        }
    }
}
