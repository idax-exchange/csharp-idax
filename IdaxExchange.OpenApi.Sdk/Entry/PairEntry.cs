using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
    public class PairEntry:BaseEntry
    {
        /**
         * pairs
         */
        [JsonProperty(PropertyName = "pairs")]
        private JsonArray pairs;
    }
}
