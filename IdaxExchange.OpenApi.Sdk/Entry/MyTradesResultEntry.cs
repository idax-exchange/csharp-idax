using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
    public class MyTradesResultEntry
    {
        /**
       * code
       */
        [JsonProperty(PropertyName = "code")]
        public string code { get; set; }
        /**
         * message
         */
        [JsonProperty(PropertyName = "msg")]
        public string msg { get; set; }
        /**
         * timestamp
         */
        [JsonProperty(PropertyName = "total")]
        public int total { get; set; }

        /**
        * Trade List
        */
        public List<MyTradesEntry> trades { get; set; }
    }
}
