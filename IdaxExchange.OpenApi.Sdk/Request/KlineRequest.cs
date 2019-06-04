using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Request
{
    [Serializable]
    public class KlineRequest
    {
        /**
         * pair
         */
        [JsonProperty(PropertyName = "pair")]
        public string pair { get; set; }
        /**
         * period
         */
        [JsonProperty(PropertyName = "period")]
        public string period { get; set; }
        /**
         * size
         */
        [JsonProperty(PropertyName = "size")]
        public int size { get; set; }
        /**
         * since
         */
        [JsonProperty(PropertyName = "since")]
        public long since { get; set; }
    }
}
