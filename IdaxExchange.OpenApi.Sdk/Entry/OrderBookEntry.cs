using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
    [Serializable]
    public class OrderBookEntry : BaseEntry
    {
        /**
        * List of bids (price/qty).
        */
        [JsonProperty(PropertyName = "bids")]
        private JsonArray bids;

        /**
         * List of asks (price/qty).
         */
        [JsonProperty(PropertyName = "asks")]
        private JsonArray asks;
    }
}
