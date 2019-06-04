using System;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class WsParam
    {
        public string apiKey { get; set; }

        public string timestamp { get; set; }

        public string sign { get; set; }
    }
}
