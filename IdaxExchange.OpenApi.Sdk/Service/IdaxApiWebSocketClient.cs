using IdaxExchange.OpenApi.Sdk.Enums;
using IdaxExchange.OpenApi.Sdk.Event;
using IdaxExchange.OpenApi.Sdk.Service.Impl;
using WebSocketSharp;

namespace IdaxExchange.OpenApi.Sdk.Service
{
    public abstract class IdaxApiWebSocketClient
    {
        public IWsCallBack callback;
    
        public   WebSocket webSocket;

        /**
         * onDepthXEvent
         *
         * @param symbol   symbol
         */
        public abstract void onDepthXEvent(string symbol);

        /**
         * onDepthXYEvent
         *
         * @param symbol   symbol
         * @param num      num
         */
        public abstract void onDepthXYEvent(string symbol, int num);

        /**
         * onTickerEvent
         *
         * @param symbol   symbol
         */
        public abstract void onTickerEvent(string symbol);

        /**
        * onKLineEvent
        *
        * @param symbol     market (one or coma-separated) symbol(s) to subscribe to
        * @param periodEnum kline period {@link PeriodEnum periodEnum}
        */
        public abstract void onKLineEvent(string symbol, PeriodEnum periodEnum);

        /**
         * onTradeEvent
         *
         * @param symbol   symbol
         */
        public abstract void onTradeEvent(string symbol);
        
        /**
        * onMyTradeEvent
        *
        * @param param    param
        */
        public abstract void onMyTradeEvent(SendMessage sendMessage);

        /**
        * onMyOrderEvent
        *
        * @param param    param
        */
        public abstract void onMyOrderEvent(SendMessage send);

    }
}
