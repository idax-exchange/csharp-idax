using System;
using System.Collections.Generic;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class TickerEventEntry
    {
        public  string channel { get; set; }
        public  List<TickerEvent> data { get; set; }
    }
}
