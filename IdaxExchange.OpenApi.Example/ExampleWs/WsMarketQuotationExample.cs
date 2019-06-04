using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdaxExchange.OpenApi.Example.Config;
using IdaxExchange.OpenApi.Example.ExampleWs;
using IdaxExchange.OpenApi.Sdk.Constant;
using IdaxExchange.OpenApi.Sdk.Enums;
using IdaxExchange.OpenApi.Sdk.Event;
using IdaxExchange.OpenApi.Sdk.Service;
using IdaxExchange.OpenApi.Sdk.Utils;

namespace IdaxExchange.OpenApi.Example.ExampleWs
{
    public class WsMarketQuotationExample
    {

        public void idaxSubXDepthExample()
        {

            /***Initialize the calling object*/
            IdaxApiWebSocketClient idaxApiWebSocketClient = IdaxConfig.wsInit();
            idaxApiWebSocketClient.callback = new WsCallback();

            /**Subscribe to myOrder**/
            idaxApiWebSocketClient.onDepthXEvent(IdaxApiConstants.ETH_BTC);
           
        }


        public void idaxSubXDepthYExample()
        {

            /***Initialize the calling object*/
            IdaxApiWebSocketClient idaxApiWebSocketClient = IdaxConfig.wsInit();
            idaxApiWebSocketClient.callback = new WsCallback();

            /**Subscribe to myOrder**/
            idaxApiWebSocketClient.onDepthXYEvent(IdaxApiConstants.ETH_BTC, int.Parse(DepthYEnum.FIFTY.GetDisplayAttribute()));
           
        }

        public void idaxSubXTickerExample()
        {

            /***Initialize the calling object*/
            IdaxApiWebSocketClient idaxApiWebSocketClient = IdaxConfig.wsInit();
            idaxApiWebSocketClient.callback = new WsCallback();
            /**Subscribe to myOrder**/
            idaxApiWebSocketClient.onTickerEvent(IdaxApiConstants.ETH_BTC);
           
        }

        public void idaxSubXKlineYExample()
        {

            /***Initialize the calling object*/
            IdaxApiWebSocketClient idaxApiWebSocketClient = IdaxConfig.wsInit();
            idaxApiWebSocketClient.callback = new WsCallback();
            /**Subscribe to myOrder**/
            idaxApiWebSocketClient.onKLineEvent(IdaxApiConstants.ETH_BTC, PeriodEnum.ONE_WEEK);
           
        }


        public void idaxSubTradeEventExample()
        {

            /***Initialize the calling object*/
            IdaxApiWebSocketClient idaxApiWebSocketClient = IdaxConfig.wsInit();
            idaxApiWebSocketClient.callback = new WsCallback();
            /**Subscribe to myOrder**/
            idaxApiWebSocketClient.onTradeEvent(IdaxApiConstants.ETH_BTC);
        
        }
        

        public void myTradeExample()
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
            idaxApiWebSocketClient.onMyTradeEvent(wsSendMessage);
           
        }
    }
}
