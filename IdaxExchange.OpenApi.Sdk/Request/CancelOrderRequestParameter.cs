using System.ComponentModel;

namespace IdaxExchange.OpenApi.Sdk.Request
{
    public class CancelOrderRequestParameter : BaseRequestParameter
    {
        public CancelOrderRequestParameter()
            :base()
        {

        }

        [Description("order Id")]
        public string orderId { get; set; }
    }
}