using System;
using System.Collections.Generic;
using IdaxExchange.OpenApi.Sdk.Entry;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class MyOrderEntry
    {
        public string code { get; set; }
        public string channel { get; set; }
        public List<MyOrderEvent> data { get; set; }
    }
}
