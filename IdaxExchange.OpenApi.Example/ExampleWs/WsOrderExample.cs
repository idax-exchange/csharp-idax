using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdaxExchange.OpenApi.Example.Config;
using IdaxExchange.OpenApi.Example.ExampleWs;
using IdaxExchange.OpenApi.Sdk.Event;
using IdaxExchange.OpenApi.Sdk.Service;
using IdaxExchange.OpenApi.Sdk.Utils;

namespace IdaxExchange.OpenApi.Example.ExampleWs
{
    public class WsOrderExample
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////client recieve message in WsCalCallback onMessage method////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /**
         * myOrderExample
         *
         */
        public void myOrderExample()
        {

            /***Initialize the calling object*/
            IdaxApiWebSocketClient idaxApiWebSocketClient = IdaxConfig.wsInit();
            idaxApiWebSocketClient.callback = new WsCallback();
            SendMessage wsSendMessage = new SendMessage();
            var wsParam = new WsParam();
            wsParam.apiKey = IdaxConfig.API_KEY;
            wsParam.timestamp = DateTime.UtcNow.UnixTimeStamp().ToString();
            wsSendMessage.parameters = wsParam;
            /**Subscribe to myOrder**/
            idaxApiWebSocketClient.onMyOrderEvent(wsSendMessage);
           
        }

    }

}
