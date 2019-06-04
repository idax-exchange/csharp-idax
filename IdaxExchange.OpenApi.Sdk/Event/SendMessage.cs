using System;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class SendMessage
    {

        [JsonProperty("event")]
        public string eventType { get; set; }
        public string channel { get; set; }
        public WsParam parameters { get; set; }

    }
}
