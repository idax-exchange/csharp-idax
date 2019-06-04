using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class MyTrade
    {
        public string B { get; set; }
        public string E { get; set; }
        public string S { get; set; }
        public string T { get; set; }
        public string a { get; set; }

        [JsonProperty(PropertyName = "as")]
        public string asData { get; set; }

        public string b { get; set; }
        public string bs { get; set; }
        public string e { get; set; }
        public string m { get; set; }
        public string p { get; set; }
        public string q { get; set; }
        public string s { get; set; }
        public string t { get; set; }
    }
}
