using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdaxExchange.OpenApi.Sdk.Event
{
    [Serializable]
    public class TickerEvent
    {
        public  string open { get; set; }
        public  string high { get; set; }
        public  string low { get; set; }
        public  string last { get; set; }
        public  long timestamp { get; set; }
        public  string vol { get; set; }
    }
}
