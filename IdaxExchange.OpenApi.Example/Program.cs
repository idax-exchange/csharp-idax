using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdaxExchange.OpenApi.Example.ExampleHttp;
using IdaxExchange.OpenApi.Example.ExampleWs;

namespace IdaxExchange.OpenApi.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Http Example
            //OK
            //HttpMarketQuotationExample.GetOrderBookExample();

            //OK
            //HttpMarketQuotationExample.GetTickerExample();

            //OK
            //HttpMarketQuotationExample.GetKlineExample();

            //OK
            //HttpMarketQuotationExample.GetTradeExample();

            //OK
            //HttpMarketQuotationExample.GetPairExample();

            //OK
            //HttpMarketQuotationExample.GetPairLimitEntryExample();

            //OK
            //HttpOrderExample.placeOrderExample();

            //OK
            //HttpOrderExample.getUserInfoExample();

            //OK
            //HttpOrderExample.getMyTradesExample();

            //OK
            //HttpOrderExample.getOrderHistoryExample();

            //OK
            //HttpOrderExample.cancelOrderExample();

            //OK
            //HttpOrderExample.GetOrderInfoExample();
            #endregion


            #region Webscoket Example

            var tasks = new List<Task>();
            WsMarketQuotationExample market = new WsMarketQuotationExample();

            ////Example Ticker OK
            //var marketTask = Task.Factory.StartNew(() =>
            //{
            //    market.idaxSubXTickerExample();
            //});
            //tasks.Add(marketTask);


            ////Example XDepthY OK
            //var subXDepthY = Task.Factory.StartNew(() =>
            //{
            //    market.idaxSubXDepthYExample();
            //});
            //tasks.Add(subXDepthY);


            //Example XDepth  OK
            //var subXDepth = Task.Factory.StartNew(() =>
            //{
            //    market.idaxSubXDepthExample();
            //});
            //tasks.Add(subXDepth);


            ////Example XKlineY  OK
            //var subXKlineY = Task.Factory.StartNew(() =>
            //{
            //    market.idaxSubXKlineYExample();
            //});
            //tasks.Add(subXKlineY);


            //Example Trade  OK
            //WsOrderExample trade = new WsOrderExample();
            //var tradeTask = Task.Factory.StartNew(() =>
            //{
            //    market.idaxSubTradeEventExample();
            //});
            //tasks.Add(tradeTask);


            ////Example MyTrade   OK
            //var myTrade = Task.Factory.StartNew(() =>
            //{
            //    market.myTradeExample();
            //});
            //tasks.Add(myTrade);


            ////Example myOrder   OK
            //WsOrderExample or = new WsOrderExample();
            //var orderTask = Task.Factory.StartNew(() =>
            //{
            //    or.myOrderExample();
            //});
            //tasks.Add(orderTask);


            Task.WaitAll(tasks.ToArray());
            Console.ReadLine();

            #endregion

        }
    }
}
