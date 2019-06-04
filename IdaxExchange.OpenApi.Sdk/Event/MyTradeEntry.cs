using System;
using System.Collections.Generic;
using IdaxExchange.OpenApi.Sdk.Entry;
using RestSharp;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class MyTradeEntry
    {
        public  string code { get; set; }
        public  string channel { get; set; }
        public  List<MyTrade> data { get; set; }
    }
}
