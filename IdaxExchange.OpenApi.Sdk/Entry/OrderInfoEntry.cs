using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
    public class OrderInfoEntry : BaseEntry
    {
        /**
        * total
        */
        [JsonProperty(PropertyName = "total")]
        private int total;
        /**
         * Order List
         */
        [JsonProperty(PropertyName = "orders")]
        private List<Order> orders;
    }
}
