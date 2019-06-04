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
    public class HttpOrderExample
    {

        public static void GetOrderInfoExample()
        {

            /***Initialize the calling object*/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Request parameter encapsulation**/
            string symbol = IdaxApiConstants.ETH_BTC;
            OrderInfoRequest orderInfoRequest = new OrderInfoRequest();
            orderInfoRequest.key = IdaxConfig.API_KEY;
            orderInfoRequest.pair = symbol;
            orderInfoRequest.pageIndex = 1;
            orderInfoRequest.pageSize = 20;
            orderInfoRequest.timestamp = DateTime.UtcNow.UnixTimeStamp();
            orderInfoRequest.orderId = 9799L;

            /**Call remote interface**/
            OrderInfoEntry orderInfoEntry = idaxApiRestClient.getOrderInfo(orderInfoRequest);

        }

        /**
        * getOrderHistoryExample
        * Get historical order information and return information only for the last two days
        */
        public static void getOrderHistoryExample()
        {

            /***Initialize the calling object*/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Request parameter encapsulation**/
            string symbol = IdaxApiConstants.ETH_BTC;
            OrderHistoryRequest orderHistoryRequest = new OrderHistoryRequest();
            orderHistoryRequest.currentPage = 1;
            orderHistoryRequest.key = IdaxConfig.API_KEY;
            orderHistoryRequest.orderState =-1;
            orderHistoryRequest.pair = symbol;
            orderHistoryRequest.timestamp = DateTime.UtcNow.UnixTimeStamp();
            orderHistoryRequest.pageLength = 10;

            /**Call remote interface**/
            OrderHistoryEntry orderHistoryEntry = idaxApiRestClient.getOrderHistory(orderHistoryRequest);

        }


        /**
        * getUserInfoExample
        * Get account info
        */
        public static void getUserInfoExample()
        {

            /***Initialize the calling object*/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Request parameter encapsulation**/
            UserInfoRequest userInfoRequest = new UserInfoRequest();
            userInfoRequest.timestamp = DateTime.UtcNow.UnixTimeStamp();
            userInfoRequest.key = IdaxConfig.API_KEY;

            /**Call remote interface**/
            UserInfoEntry userInfoEntry = idaxApiRestClient.getUserInfo(userInfoRequest);

        }



        /**
       * getMyTradesExample
       * Get my historical trading information
       */
        public static void getMyTradesExample()
        {

            /***Initialize the calling object*/
            IdaxApiRestClient idaxApiRestClient = IdaxConfig.init();

            /**Request parameter encapsulation**/
            string symbol = IdaxApiConstants.ETH_BTC;

            MyTradesRequest myTradesRequest = new MyTradesRequest();
            myTradesRequest.key = IdaxConfig.API_KEY;
            myTradesRequest.pair = symbol;
            myTradesRequest.orderSide = OrderSideEnum.Sell.GetDisplayAttribute();
            myTradesRequest.currentPage = 0;
            myTradesRequest.pageLength = 20;
            myTradesRequest.startDate = DateTime.UtcNow.AddDays(-2).UnixTimeStamp();
            myTradesRequest.endDate = DateTime.UtcNow.UnixTimeStamp();
            myTradesRequest.timestamp = DateTime.UtcNow.UnixTimeStamp();

            /**Call remote interface**/
            MyTradesResultEntry myTradesEntry = idaxApiRestClient.getMyTrades(myTradesRequest);

        }

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
}
