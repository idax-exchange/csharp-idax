using System;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Request
{
    [Serializable]
    public class OrderInfoRequest
    {
        /**
         * apikey
         */
        [JsonProperty(PropertyName = "key")]
        public string key { get; set; }
        /**
         * symbol in idax
         */
        [JsonProperty(PropertyName = "pair")]
        public string pair { get; set; }
        /**
         * order no
         */
        [JsonProperty(PropertyName = "orderId")]
        public long orderId { get; set; }
        /**
         * current page no
         */
        [JsonProperty(PropertyName = "pageIndex")]
        public int pageIndex { get; set; }
        /**
         * number per page
         */
        [JsonProperty(PropertyName = "pageSize")]
        public int pageSize { get; set; }
        /**
         * timestamp expired after 3 minures
         */
        [JsonProperty(PropertyName = "timestamp")]
        public long timestamp { get; set; }
        /**
         * sign
         */
        [JsonProperty(PropertyName = "sign")]
        public string sign { get; set; }
    }
}
