namespace IdaxExchange.OpenApi.Sdk.Request
{
    public class CancelOrderRequest: BaseRequestParameter
    {
        /**
         * order no ,seperate in ,
         */
        public string orderId { get; set; }
    }
}
