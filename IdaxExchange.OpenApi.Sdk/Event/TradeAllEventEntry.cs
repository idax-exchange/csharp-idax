using System;
using System.Collections.Generic;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class TradeAllEventEntry
    {
        public string code { get; set; }
        public string channel { get; set; }
        public List<TradeAllEvent> data { get; set; }
    }
}
