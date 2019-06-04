using System;
using RestSharp;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class BatchRegisterEventEntry
    {
        public JsonArray data { get; set; }
    }
}
