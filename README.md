# IDAX API

To read full documentation, specs and find out which request params are required/optional, please visit the official
[documentation](https://github.com/idax-exchange/idax-official-api-docs) page.

## Getting started
add IdaxExchange.OpenApi.Sdk.dll into your program


1-Initialize config
```C#
public class IdaxConfig
{            
        //YOUR API KEY
        public static string API_KEY = "your apikey";       
        //YOUR SECRET
        public static string SECRET = "your secret";
        //IDAX REST OPEN API BASE URL.
        public static string API_BASE_URL = "https://openapi.idax.mn";
       //IDAX WS OPEN API BASE URL.
        public static string WS_API_BASE_URL = "wss://openws.idax.mn/ws";  
        
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

```
2-1 Initialize REST client service
```C#
IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();
/**Request parameter encapsulation**/
string symbol = IdaxApiConstants.ETH_BTC;
PlaceOrderRequest placeOrderRequest = new PlaceOrderRequest();
placeOrderRequest.pair = "APL_BTC";
placeOrderRequest.timestamp = DateTime.UtcNow.UnixTimeStamp();
placeOrderRequest.amount = "11211111";
placeOrderRequest.price = "0.00000007";
placeOrderRequest.orderType = OrderTypeEnum.Limit.GetDisplayAttribute();
placeOrderRequest.orderSide = OrderSideEnum.Buy.GetDisplayAttribute();
placeOrderRequest.key = IdaxConfig.API_KEY;
/**Call remote interface**/
PlaceOrderEntry placeOrderEntry = idaxApiRestClient.placeOrder(placeOrderRequest);

```
2-2 Initialize Websocket client service
```C#

/***Initialize the calling object**/
 public class WsCallback : IWsCallBack
    {
        /// <summary>
        /// Receiving message from the server pushed
        /// </summary>
        /// <param name="message"></param>
        void IWsCallBack.onMessage(string message)
        {
            var baseWsMsgEntry = JsonConvert.DeserializeObject<BaseWsMsgEntry<string>>(message);
            Console.WriteLine(baseWsMsgEntry.channel);
            var msgChannel = baseWsMsgEntry.channel.ToLower();
            #region Deserialize

            //channel:idax_sub_myorder
            if (msgChannel.Equals(IdaxApiConstants.CHANNEL_MY_ORDER, StringComparison.CurrentCultureIgnoreCase))
            {
                var data = JsonConvert.DeserializeObject<MyOrderEntry>(message);
                Console.WriteLine(JsonConvert.SerializeObject(data));
            }
            else if (msgChannel.Equals(IdaxApiConstants.CHANNEL_MY_TRADE,
                    StringComparison.CurrentCultureIgnoreCase))//channel:idax_sub_mytrade
            {
                var data = JsonConvert.DeserializeObject<MyTradeEntry>(message);
                Console.WriteLine(JsonConvert.SerializeObject(data));
            }
            else if (msgChannel.Contains("_ticker"))//channel:idax_sub_{symbol}_ticker
            {
                var data = JsonConvert.DeserializeObject<TickerEventEntry>(message);
                Console.WriteLine(JsonConvert.SerializeObject(data));
            }
            else if (msgChannel.Contains("_depth_"))//channel:idax_sub_{symbol}_depth_{number}
            {
                var data = JsonConvert.DeserializeObject<DepthEvent>(message);
                Console.WriteLine(JsonConvert.SerializeObject(data));
            }
            else if (msgChannel.Contains("_kline_"))//channel:idax_sub_{symbol}_kline_{period}
            {
                var data = JsonConvert.DeserializeObject<KlineEventEntry>(message);
                Console.WriteLine(JsonConvert.SerializeObject(data));
            }
            else if (msgChannel.Contains("_trades"))//channel:idax_sub_{symbol}_trades
            {
                var data = JsonConvert.DeserializeObject<TradeEventEntry>(message);
                Console.WriteLine(JsonConvert.SerializeObject(data));
            }
            else if (msgChannel.Contains("_depth") && !msgChannel.Contains("_depth_"))//channel:idax_sub_{symbol}_depth
            {
                var data = JsonConvert.DeserializeObject<DepthEvent>(message);
                Console.WriteLine(JsonConvert.SerializeObject(data));
            }
            else
            {
                Console.WriteLine($"The channel was not found,message is:{message}");
            }


            #endregion
            
            Console.WriteLine("===============================");
        }

    }
/**Request parameter encapsulation**/
IdaxApiWebSocketClient idaxApiWebSocketClient = IdaxConfig.wsInit();
idaxApiWebSocketClient.callback = new WsCallback();
SendMessage wsSendMessage = new SendMessage();
var wsParam = new WsParam();
wsParam.apiKey = IdaxConfig.API_KEY;
wsParam.timestamp = DateTime.UtcNow.UnixTimeStamp().ToString();
wsSendMessage.parameters = wsParam;
/**Subscribe to myOrder**/
idaxApiWebSocketClient.onMyOrderEvent(wsSendMessage);
```


## Examples

Following provides list of main usages of library. See `example` package for testing application with more examples.

Each call has its own *Request* structure with data that can be provided. The library is not responsible for validating
the input and if non-zero value is used, the param is sent to the API server.



### PlaceOrder

```C#
 public class HttpOrderExample
    {
 		 /**
          * placeOrderExample
          * Create new order
          */
        public static void placeOrderExample()
        {

            /***Initialize the calling object**/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Request parameter encapsulation**/
            string symbol = IdaxApiConstants.ETH_BTC;
            PlaceOrderRequest placeOrderRequest = new PlaceOrderRequest();
            placeOrderRequest.pair = "APL_BTC";
            placeOrderRequest.timestamp = DateTime.UtcNow.UnixTimeStamp();
            placeOrderRequest.amount = "11211111";
            placeOrderRequest.price = "0.00000007";
            placeOrderRequest.orderType = OrderTypeEnum.Limit.GetDisplayAttribute();
            placeOrderRequest.orderSide = OrderSideEnum.Buy.GetDisplayAttribute();
            placeOrderRequest.key = IdaxConfig.API_KEY;

            /**Call remote interface**/
            PlaceOrderEntry placeOrderEntry = idaxApiRestClient.placeOrder(placeOrderRequest);

        }
 }
class Program
{
    static void Main(string[] args)
    {
        HttpOrderExample.placeOrderExample();
    }
}

```

### CancelOrder

```C#
 public class HttpOrderExample
{
    /**
        * cancelOrderExample
        * Cancel orders
        */
        public static void cancelOrderExample()
        {

            /***init IdaxApiRestClient*/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Request parameter encapsulation**/
            CancelOrderRequest cancelOrderRequest = new CancelOrderRequest();
            cancelOrderRequest.key = IdaxConfig.API_KEY;
            cancelOrderRequest.timestamp = DateTime.UtcNow.UnixTimeStamp();
            cancelOrderRequest.orderId = "3259662510000000069";

            /**Call remote interface**/
            CancelOrderEntry cancelOrderEntry = idaxApiRestClient.cancelOrder(cancelOrderRequest);

        }
 }
class Program
{
    static void Main(string[] args)
    {
        HttpOrderExample.cancelOrderExample();
    }
}
```

    
### Trade Websocket

```C#
public class WsMarketQuotationExample
    {
    	  //Example XDepthY 
        public void idaxSubXDepthExample()
        {
            /***Initialize the calling object*/
            IdaxApiWebSocketClient idaxApiWebSocketClient = IdaxConfig.wsInit();
            idaxApiWebSocketClient.callback = new WsCallback();

            /**Subscribe to myOrder**/
            idaxApiWebSocketClient.onDepthXEvent(IdaxApiConstants.ETH_BTC);           
        }
		  //Example XDepth  
        public void idaxSubXDepthYExample()
        {
            /***Initialize the calling object*/
            IdaxApiWebSocketClient idaxApiWebSocketClient = IdaxConfig.wsInit();
            idaxApiWebSocketClient.callback = new WsCallback();

            /**Subscribe to myOrder**/
            idaxApiWebSocketClient.onDepthXYEvent(IdaxApiConstants.ETH_BTC, 		  int.Parse(DepthYEnum.FIFTY.GetDisplayAttribute()));
           
        }
        
        //Example MyTrade   
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

 class Program
{
    static void Main(string[] args)
    {
         var tasks = new List<Task>();
         WsMarketQuotationExample market = new WsMarketQuotationExample();
          //Example XDepthY
            var subXDepthY = Task.Factory.StartNew(() =>
            {
                market.idaxSubXDepthYExample();
            });
            tasks.Add(subXDepthY);

            //Example XDepth 
            var subXDepth = Task.Factory.StartNew(() =>
            {
                market.idaxSubXDepthExample();
            });
            tasks.Add(subXDepth);
            
            //Example MyTrade
            var myTrade = Task.Factory.StartNew(() =>
            {
                market.myTradeExample();
            });
            tasks.Add(myTrade);            
            
             Task.WaitAll(tasks.ToArray());
            Console.ReadLine();
    }
 }
        
```

## Known issues

* Websocket error handling is not perfect and occasionally attempts to read from closed connection.
