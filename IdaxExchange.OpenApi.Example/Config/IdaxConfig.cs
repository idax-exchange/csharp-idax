using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdaxExchange.OpenApi.Sdk.Service;

namespace IdaxExchange.OpenApi.Example.Config
{
    public class IdaxConfig
    {
     
        //stage
        /**
        * YOUR API KEY
        */
        public static string API_KEY = "your API_KEY";

        /**
         * YOUR SECRET
         */
        public static string SECRET = "your SECRET";


        /**
          * IDAX REST OPEN API BASE URL.
          */
        public static string API_BASE_URL = "https://openapi.idax.pro";

        /**
         * IDAX WS OPEN API BASE URL.
         */
        public static string WS_API_BASE_URL = "wss://openws.idax.pro/ws";



        /**
         * init IdaxApiClientFactory
         *
         * @return IdaxApiRestClient
         */
        public static IdaxApiRestClient init()
        {

            IdaxApiClientFactory factory = IdaxApiClientFactory.NewInstance(API_KEY, SECRET, API_BASE_URL);

            return factory.newRestClient();
        }

        /**
         * wsInit  WebSocketClient
         * @return IdaxApiWebSocketClient
         */
        public static IdaxApiWebSocketClient wsInit()
        {

            IdaxApiClientFactory webSocketClient = IdaxApiClientFactory.NewInstance(API_KEY, SECRET, WS_API_BASE_URL);

            return webSocketClient.newWebSocketClient();
        }

    }

}
