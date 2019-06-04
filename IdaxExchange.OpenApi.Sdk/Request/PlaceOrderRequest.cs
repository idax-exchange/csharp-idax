using System;

namespace IdaxExchange.OpenApi.Sdk.Request
{
    [Serializable]
    public class PlaceOrderRequest
    {
        /**
         * key
         */
        public string key { get; set; }
        /**
         * symbol in idax
         */
        public string pair { get; set; }
        /**
         * order type {@link com.idax.api.client.enums.OrderTypeEnum}
         */
        public string orderType { get; set; }
        /**
         * order side {@link com.idax.api.client.enums.OrderSideEnum}
         */
        public string orderSide { get; set; }
        /**
         * order price
         */
        public string price { get; set; }
        /**
         * order number
         */
        public string amount { get; set; }
        /**
         * sign
         */
        public string sign { get; set; }
        /**
         * timestamp expired after 3 minutes
         */
        public long timestamp { get; set; }
    }
}
