using IdaxExchange.OpenApi.Sdk.Constant;
using IdaxExchange.OpenApi.Sdk.Enums;
using IdaxExchange.OpenApi.Sdk.Event;
using IdaxExchange.OpenApi.Sdk.Utils;
using WebSocketSharp;

namespace IdaxExchange.OpenApi.Sdk.Service.Impl
{
    public class IdaxApiWebSocketClientImpl: IdaxApiWebSocketClient
    {
        
        private string apiKey;
        private string secret;
        private string apiBaseUrl;
        
        private static readonly object SyncRootWebSocketInstance = new object();
        private static readonly object SyncRootWebSocketStatus = new object();


        public IdaxApiWebSocketClientImpl(string apiKey, string secret, string apiBaseUrl)
        {
            this.apiKey = apiKey;
            this.secret = secret;
            this.apiBaseUrl = apiBaseUrl;
            
        }

        public override void onMyOrderEvent(SendMessage sendMessage)
        {
            var channel = IdaxApiConstants.CHANNEL_MY_ORDER;
            sendMessage.eventType= EventTypeEnum.ADD_CHANNEL.GetDisplayAttribute();
            sendMessage.channel= channel;
            sendMessage.parameters.sign= SignUtil.GetSign(sendMessage.parameters, secret); ;

            createNewWebSocket(channel, sendMessage);
        }
        

        public override void onDepthXEvent(string symbol)
        {
            var channel = IdaxApiConstants.CHANNEL_DEPTH_X;
            var sendMessage = new SendMessage();
            sendMessage.eventType= EventTypeEnum.ADD_CHANNEL.GetDisplayAttribute();
            sendMessage.channel= channel.Replace("{symbol}", symbol); 

            createNewWebSocket(channel, sendMessage);
        }

        public override void onDepthXYEvent(string symbol, int num)
        {
            var channel = IdaxApiConstants.CHANNEL_DEPTH_XY;
            var sendMessage = new SendMessage();
            sendMessage.eventType = EventTypeEnum.ADD_CHANNEL.GetDisplayAttribute();
            sendMessage.channel = channel.Replace("{symbol}", symbol).Replace("{number}", num.ToString());

            createNewWebSocket(channel, sendMessage);
        }

        public override void onTickerEvent(string symbol)
        {
            var channel = IdaxApiConstants.CHANNEL_TICKER;
            var sendMessage = new SendMessage();
            sendMessage.eventType = EventTypeEnum.ADD_CHANNEL.GetDisplayAttribute();
            sendMessage.channel = channel.Replace("{symbol}", symbol);

            createNewWebSocket(channel, sendMessage);
        }

        public override void onKLineEvent(string symbol, PeriodEnum periodEnum)
        {
            var channel = IdaxApiConstants.CHANNEL_KLINE;
            var sendMessage = new SendMessage();
            sendMessage.eventType = EventTypeEnum.ADD_CHANNEL.GetDisplayAttribute();
            sendMessage.channel = channel.Replace("{symbol}", symbol).Replace("{period}", periodEnum.GetDisplayAttribute());

            createNewWebSocket(channel, sendMessage);
        }

        public override void onTradeEvent(string symbol)
        {
            var channel = IdaxApiConstants.CHANNEL_TRADE;
            var sendMessage = new SendMessage();
            sendMessage.eventType = EventTypeEnum.ADD_CHANNEL.GetDisplayAttribute();
            sendMessage.channel = channel.Replace("{symbol}", symbol);

            createNewWebSocket(channel, sendMessage);
        }


        public override void onMyTradeEvent(SendMessage sendMessage)
        {
            var channel = IdaxApiConstants.CHANNEL_MY_TRADE;
            sendMessage.eventType = EventTypeEnum.ADD_CHANNEL.GetDisplayAttribute();
            sendMessage.channel = channel;
            sendMessage.parameters.sign = SignUtil.GetSign(sendMessage.parameters, secret); ;

            createNewWebSocket(channel, sendMessage);
        }

        
        private void createNewWebSocket(string channel, SendMessage sendMessage)
        {
           
            var ws = getWebSocketInstance();
            if (ws.IsAlive)
            {
                ws.Send(JsonUtil.ToJsonStringRemoveNull(sendMessage));
            }
            else
            {
                lock (SyncRootWebSocketStatus)
                {
                    if (ws.IsAlive)
                    {
                        ws.Send(JsonUtil.ToJsonStringRemoveNull(sendMessage));
                    }
                    else
                    {
                        ws.OnOpen += (sender, e) => ws.Send(JsonUtil.ToJsonStringRemoveNull(sendMessage));

                        ws.OnMessage += (sender, e) => { callback.onMessage(e.Data); };
                        ws.Connect();
                    }
                }
            }

        }
        
        public WebSocket getWebSocketInstance()
        {

            if (webSocket == null)
            {
                lock (SyncRootWebSocketInstance)
                {
                    if (webSocket == null)
                    {
                        webSocket = new WebSocket(apiBaseUrl);
                    }
                }

            }
            return webSocket;
        }
    }
}
