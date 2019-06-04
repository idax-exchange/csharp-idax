using System;
using RestSharp;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class DepthEvent
    {
        public string channel{get;set;}
        public JsonArray data { get; set; }

        
    }
}
