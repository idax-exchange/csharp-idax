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
    public class OrderHistoryEntry : BaseSimpleEntry
    {
        /**
         * current page
         */
        public int currentPage { get; set; }
        /**
         * page number
         */
        public int pageLength { get; set; }
        /**
         * total
         */
        public int total { get; set; }
        /**
         * Order List
         */
        public List<Order> orders { get; set; }
    }
}
