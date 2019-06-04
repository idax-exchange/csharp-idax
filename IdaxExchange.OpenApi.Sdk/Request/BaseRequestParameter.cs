using System.ComponentModel;

namespace IdaxExchange.OpenApi.Sdk.Request
{
    public class BaseRequestParameter
    {
        [Description("Api Key")]
        public string key { get; set; }
        
        [Description("timestamp")]
        public long timestamp { get; set; }

        [Description("sign")]
        public string sign { get; set; }
    }
}