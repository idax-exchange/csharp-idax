using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
    [Serializable]
    public class TickerEntry :BaseEntry
    {
        /**
        * Ticker List
        */
        [JsonProperty(PropertyName = "ticker")]
        public List<Ticker> Ticker { get; set; }
    }
}
