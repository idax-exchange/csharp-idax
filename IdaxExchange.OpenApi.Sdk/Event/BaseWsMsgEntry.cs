using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class BaseWsMsgEntry<T>
    {
        public string channel { get; set; }

        public string code { get; set; }

        public JsonArray data { get; set; }
    }
}
