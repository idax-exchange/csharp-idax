using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdaxExchange.OpenApi.Example.Config;
using IdaxExchange.OpenApi.Sdk.Constant;
using IdaxExchange.OpenApi.Sdk.Entry;
using IdaxExchange.OpenApi.Sdk.Enums;
using IdaxExchange.OpenApi.Sdk.Request;
using IdaxExchange.OpenApi.Sdk.Service;
using IdaxExchange.OpenApi.Sdk.Utils;

namespace IdaxExchange.OpenApi.Example.ExampleHttp
{
    public class HttpMarketQuotationExample
    {
        /**
         * getOrderBookExample
         * Get the market depth for specific market.
         */
        public static void GetOrderBookExample()
        {

            /***Initialize the calling object*/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Request parameter encapsulation**/
            string symbol = IdaxApiConstants.ETH_BTC;

            /**Call remote interface**/
            OrderBookEntry orderBook = idaxApiRestClient.getOrderBook(symbol);

        }


        /**
         * getTickerExample
         * Get the price of specific ticker
         */
        public static void GetTickerExample()
        {

            /***Initialize the calling object*/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Request parameter encapsulation**/
            string symbol = IdaxApiConstants.ETH_BTC;

            /**Call remote interface**/
            TickerEntry tickerEntry = idaxApiRestClient.getTickerEntry(symbol);

        }


        /**
    * getKlineExample
    * Get kline data
    */
        public static void GetKlineExample()
        {

            /***Initialize the calling object*/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Request parameter encapsulation**/
            string symbol = IdaxApiConstants.ETH_BTC;
            KlineRequest kLineRequest = new KlineRequest();
            kLineRequest.pair = symbol;
            kLineRequest.period = PeriodEnum.ONE_WEEK.GetDisplayAttribute();
            kLineRequest.size = 10;
            kLineRequest.since = DateTime.UtcNow.UnixTimeStamp();

            /**Call remote interface**/
            KlineEntry klineEntry = idaxApiRestClient.getKlineEntry(kLineRequest);

        }


        /**
        * getTradeExample
        * Get Recently Trades
        */
        public static void GetTradeExample()
        {

            /***Initialize the calling object*/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Request parameter encapsulation**/
            string symbol = IdaxApiConstants.ETH_BTC;

            /**Call remote interface**/
            TradeEntry tradeEntry = idaxApiRestClient.getTradeEntry(symbol);

        }


        /**
           * getPairExample
           * All trading pairs supported by exchanges
           */
        public static void GetPairExample()
        {

            /***Initialize the calling object*/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Call remote interface**/
            PairEntry pairEntry = idaxApiRestClient.getPairEntry();

        }

        public static void GetPairLimitEntryExample()
        {

            /***Initialize the calling object*/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Request parameter encapsulation**/
            string symbol = IdaxApiConstants.ETH_BTC;

            /**Call remote interface**/
            PairLimitEntry pairLimitEntry = idaxApiRestClient.getPairLimitEntry(symbol);

        }


    }
}
