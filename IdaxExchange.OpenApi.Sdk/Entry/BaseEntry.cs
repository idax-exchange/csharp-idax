using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
    [Serializable]
    public class BaseEntry
    {
        /**
        * code
        */
        [JsonProperty(PropertyName = "code")]
        private string code;
        /**
         * message
         */
        [JsonProperty(PropertyName = "msg")]
        private string msg;
        /**
         * timestamp
         */
        [JsonProperty(PropertyName = "timestamp")]
        private long timestamp;
    }
}
