using System;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class MyOrderEvent
    {
        [JsonProperty(PropertyName = "createtime")]
        public string createTime { get; set; }

        [JsonProperty(PropertyName = "feerate")]
        public decimal feeRate{ get; set; }

        [JsonProperty(PropertyName = "filledamount")]
        public decimal  filledAmount{ get; set; }

        [JsonProperty(PropertyName = "filledQty")]
        public decimal  filledqty{ get; set; }

        [JsonProperty("frozen")]
        public decimal  frozen{ get; set; }

        [JsonProperty(PropertyName = "id")]
        public long id{ get; set; }

        [JsonProperty(PropertyName = "orderside")]
        public int orderSide{ get; set; }

        [JsonProperty(PropertyName = "orderstate")]
        public int orderState{ get; set; }

        [JsonProperty(PropertyName = "ordertype")]
        public int orderType{ get; set; }

        [JsonProperty(PropertyName = "pairname")]
        public string symbol{ get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal price{ get; set; }

        [JsonProperty(PropertyName = "total")]
        public decimal total{ get; set; }

        [JsonProperty(PropertyName = "updatetime")]
        public string updateTime{ get; set; }

        [JsonProperty(PropertyName = "userid")]
        public int userId{ get; set; }
    }
}
