using System;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class TradeAllEvent
    {
        [JsonProperty(PropertyName = "e")]
        public string eventType;
        
        [JsonProperty(PropertyName = "E")]
        public long eventTime;

        [JsonProperty(PropertyName = "s")]
        public string symbol;

        /**
         * Trade id.
         */
        [JsonProperty(PropertyName = "t")]
        public long tradeId;

        /**
         * Price.
         */
        [JsonProperty(PropertyName = "p")]
        public string price;

        /**
         * Original quantity in the order.
         */
        [JsonProperty(PropertyName = "q")]
        public string quantity;

        /**
         * bid order id .
         */
        [JsonProperty(PropertyName = "b")]
        public long bidOrderId;

        [JsonProperty(PropertyName = "a")]
        public long askOrderId;

        [JsonProperty(PropertyName = "as")]
        public int askOrderStatus;

        [JsonProperty(PropertyName = "bs")]
        public int bidOrderStatus;

        [JsonProperty(PropertyName = "T")]
        public long tradeTime;

        [JsonProperty(PropertyName = "B")]
        public int buyAccountId;

        [JsonProperty(PropertyName = "S")]
        public int sellAccountId;

        /**
         * flag of market maker (true: market maker)
         */
        [JsonProperty(PropertyName = "m")]
        public bool flag;
    }
}
