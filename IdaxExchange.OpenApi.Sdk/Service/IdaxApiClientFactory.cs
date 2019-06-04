using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdaxExchange.OpenApi.Sdk.Service;
using IdaxExchange.OpenApi.Sdk.Service.Impl;

namespace IdaxExchange.OpenApi.Sdk.Service
{
    public  class IdaxApiClientFactory
    {
        private static volatile IdaxApiClientFactory idaxApiClientFactoryInstance;
        private static volatile IdaxApiWebSocketClient idaxApiWebSocketClient;
        private static readonly object SyncRootRest=new object();
        private static readonly object SyncRootWebSocket = new object();

        /**
        * API Key
        */
        private readonly string ApiKey;

        /**
         * Secret
         */
        private readonly string Secret;

        /**
         * api Base Url
         */
        private readonly string ApiBaseUrl;
        /**
         * Instantiates a new Idax api client factory.
         *
         * @param apiKey the API key
         * @param secret the Secret
         */

        private IdaxApiClientFactory() { }

        private IdaxApiClientFactory(string apiKey, string secret, string apiBaseUrl)
        {
            ApiKey = apiKey;
            Secret = secret;
            ApiBaseUrl = apiBaseUrl;
        }

     
        public static IdaxApiClientFactory NewInstance(string apiKey, string secret, string apiBaseUrl)
        {

            if (idaxApiClientFactoryInstance == null)
            {
                lock (SyncRootRest)
                {
                    if (idaxApiClientFactoryInstance == null)
                    {
                        idaxApiClientFactoryInstance = new IdaxApiClientFactory(apiKey, secret, apiBaseUrl);
                    }
                }
                
            }

            return idaxApiClientFactoryInstance;
        }

        public IdaxApiRestClient newRestClient()
        {

            return new IdaxApiRestClientImpl(ApiKey, Secret, ApiBaseUrl);
        }

        
        public IdaxApiWebSocketClient newWebSocketClient()
        {

            if (idaxApiWebSocketClient == null)
            {
                lock (SyncRootWebSocket)
                {
                    if (idaxApiWebSocketClient == null)
                    {
                        idaxApiWebSocketClient = new IdaxApiWebSocketClientImpl(ApiKey, Secret, ApiBaseUrl);
                    }
                }

            }
            return idaxApiWebSocketClient;
        }
    }
}
