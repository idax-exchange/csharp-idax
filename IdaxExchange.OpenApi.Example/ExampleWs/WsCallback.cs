using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdaxExchange.OpenApi.Sdk.Constant;
using IdaxExchange.OpenApi.Sdk.Event;
using IdaxExchange.OpenApi.Sdk.Service.Impl;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Example.ExampleWs
{
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
}
