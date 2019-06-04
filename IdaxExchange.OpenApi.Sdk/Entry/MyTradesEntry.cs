using System;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
   
    [Serializable]
    public class MyTradesEntry 
    {
        /**
         * timestamp
         */
        [JsonProperty(PropertyName = "timestamp")]
        private long timestamp;
        /**
         * order price
         */
        public string price { get; set; }
        /**
         * order quantity
         */
        public string quantity { get; set; }
        /**
         * pair
         */
        public string pair { get; set; }
        /**
         * buy/sell
         */
        public string maker { get; set; }
    }
}
