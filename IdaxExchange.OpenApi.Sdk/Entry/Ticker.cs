using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
    [Serializable]
    public class Ticker
    {
        /**
         * Ticker pair.
         */
        [JsonProperty(PropertyName = "pair")]
        private string pair;

        /**
         * Open price 24 hours ago.
         */
        [JsonProperty(PropertyName = "open")]
        private string open;

        /**
         * Highest price during the past 24 hours.
         */
        [JsonProperty(PropertyName = "high")]
        private string high;

        /**
         * Lowest price during the past 24 hours.
         */
        [JsonProperty(PropertyName = "low")]
        private string low;

        /**
         * lastst price during the past 24 hours.
         */
        [JsonProperty(PropertyName = "last")]
        private string last;

        /**
         * Total volume during the past 24 hours.
         */
        [JsonProperty(PropertyName = "vol")]
        private string vol;

    }
}
