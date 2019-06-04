using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IdaxExchange.OpenApi.Sdk.Constant
{

    /**
     * @program: IdaxApiConstants
     * @description: Constants used throughout idax's API.
     * @author: wang.ou (oneou6688@163.com)
     * @create: 2019/04/25 17:10
     */
    public class IdaxApiConstants
    {


        /**
         * Default ToStringStyle used by toString methods. 
         * Override this to change the output format of the overridden toString methods. 
         *  - Example ToStringStyle.JSON_STYLE
         */
        //public static ToStringStyle TO_STRING_BUILDER_STYLE = ToStringStyle.SHORT_PREFIX_STYLE;

        /**
         * no sign
         */
        public const string URL_DEPTH = "/api/v2/depth?pair=#{symbol}";
                   
        public const string URL_TICKER = "/api/v2/ticker?pair=#{symbol}";
                  
        public const string URL_K_LINE = "/api/v2/kline";
              
        public const string URL_TRADE = "/api/v2/trades?pair=#{symbol}";
              
        public const string URL_PAIR = "/api/v2/pairs";
              
        public const string URL_PAIR_LIMIT = "/api/v2/pairLimits?pair=#{symbol}";

        /**
         * verify sign after
         */
        public const string URL_ORDER_LIST = "/api/v2/orderList";
              
        public const string URL_ORDER_INFO = "/api/v2/orderInfo";
              
        public const string URL_ORDER_HISTORY = "/api/v2/orderHistory";
              
        public const string URL_USER_INFO = "/api/v2/userinfo";
              
        public const string URL_TRADE_HISTORY = "/api/v2/tradesHistory";
              
        public const string URL_PLACE_ORDER = "/api/v2/placeOrder";
               
        public const string URL_CANCEL_ORDER = "/api/v2/cancelOrder";
              
        public const string URL_MY_TRADES = "/api/v2/myTrades";

        /**
         * webSocket
         */
        public const string CHANNEL_TICKER = "idax_sub_{symbol}_ticker";

        public const string CHANNEL_DEPTH_X = "idax_sub_{symbol}_depth";

        public const string CHANNEL_DEPTH_XY = "idax_sub_{symbol}_depth_{number}";

        public const string CHANNEL_KLINE = "idax_sub_{symbol}_kline_{period}";

        public const string CHANNEL_TRADE = "idax_sub_{symbol}_trades";

        public const string CHANNEL_MY_TRADE = "idax_sub_mytrade";

        public const string CHANNEL_MY_ORDER = "idax_sub_myorder";
        
        

        public const string ETH_BTC = "ETH_BTC";
        
    }

}
