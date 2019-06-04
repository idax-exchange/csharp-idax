using System;

namespace IdaxExchange.OpenApi.Sdk.Request
{
    [Serializable]
    public class OrderHistoryRequest
    {
        /**
         * apikey
         * required
         */
        public string key { get; set; }
        /**
         * symbol
         * required
         */
        public string pair { get; set; }
        /**
         * order status -1:all, 0：unfinish, 1：finish。
         * required
         */
        public int orderState { get; set; }
        /**
         * current page
         * required
         */
        public int currentPage { get; set; }
        /**
         * number of page
         * required
         */
        public int pageLength { get; set; }
        /**
         * is valid int 3minute
         * required
         */
        public long timestamp { get; set; }
        /**
         * sign
         * required
         */
        public string sign { get; set; }

    }
}
