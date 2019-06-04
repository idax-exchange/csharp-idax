namespace IdaxExchange.OpenApi.Sdk.Request
{
    public class MyTradesRequest
    {
        /**
        * IDAX supports trade pairs
        */
        public string pair { get; set; }
        /**
         * buy，sell
         */
        public string orderSide { get; set; }
        /**
         * current page number
         */
        public int currentPage { get; set; }
        /**
         * number of trade returned per page, maximum 1000
         */
        public int pageLength { get; set; }
        /**
         * start date and timestamp (Millisecond)
         */
        public long startDate { get; set; }
        /**
         * end date and timestamp (Millisecond)
         */
        public long endDate { get; set; }
        /**
         * apiKey of the user
         */
        public string key { get; set; }
        /**
         * signature of request parameters
         */
        public string sign { get; set; }
        /**
         * request timestamp (valid for 3 minutes)
         */
        public long timestamp { get; set; }
    }
}
