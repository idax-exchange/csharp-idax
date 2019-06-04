using System;

namespace IdaxExchange.OpenApi.Sdk.Request
{
    [Serializable]
    public class UserInfoRequest
    {
        /**
        * key
        */
        public string key { get; set; }
        /**
         * sign
         */
        public string sign { get; set; }
        /**
         * timestamp
         */
        public long timestamp { get; set; }
    }
}
