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
    public class TradeEntry : BaseEntry
    {
        /**
         * kline List
         */
        [JsonProperty(PropertyName = "trades")]
        private JsonArray Trades;
    }
}
