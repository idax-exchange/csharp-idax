using System;
using IdaxExchange.OpenApi.Sdk.Entry;
using RestSharp;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class KlineEventEntry:BaseEntry
    {
        public string code { get; set; }
        public string channel { get; set; }
        public JsonArray data { get; set; }
    }
}
