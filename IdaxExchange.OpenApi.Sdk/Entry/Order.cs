using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
    [Serializable]
    public class Order
    {
        /**
         * delegate number.
         */
        [JsonProperty(PropertyName = "quantity")]
        public string quantity { get; set; }

        /**
         * average price.
         */
        [JsonProperty(PropertyName = "avgPrice")]
        public string avgPrice { get; set; }
        /**
         * delegate time
         */
        [JsonProperty(PropertyName = "timestamp")]
        public long timestamp { get; set; }
        /**
         * deal number
         */
        [JsonProperty(PropertyName = "dealQuantity")]
        public string dealQuantity { get; set; }
        /**
         * order no
         */
        [JsonProperty(PropertyName = "orderId")]
        public long orderId { get; set; }
        /**
         * delegate price
         */
        [JsonProperty(PropertyName = "price")]
        public string price { get; set; }
        /**
         * delegate status 1:No deal 2:Partial deal 9:Complete deal 19:Withdrawal
         */
        [JsonProperty(PropertyName = "orderState")]
        public string orderState { get; set; }
        /**
         * order side 1:buy/2:sell
         */
        [JsonProperty(PropertyName = "orderSide")]
        public string orderSide { get; set; }

    }
}
