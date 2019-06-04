using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
    
    [Serializable]
    public class UserInfoEntry : BaseEntry
    {
        /**
        * total ->total asset
        **/
        public JsonObject total { get; set; }
        /**
         * free->available asset
         */
        public JsonObject free { get; set; }
        /**
         * freezed-> freeze asset
         */
        public JsonObject freezed { get; set; }
    }

}
