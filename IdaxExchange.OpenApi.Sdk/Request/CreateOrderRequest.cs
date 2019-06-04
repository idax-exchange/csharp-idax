using System.ComponentModel;
using IdaxExchange.OpenApi.Sdk.Enums;

namespace IdaxExchange.OpenApi.Sdk.Request
{ 
    public class CreateOrderRequest : BaseRequestParameter
    {
        public OrderSideEnum orderSide { get; set; }
        
        public OrderTypeEnum orderType { get; set; }
        
        public string pair { get; set; }
        
        public decimal price { get; set; }
        
        public decimal amount { get; set; }
    }
}