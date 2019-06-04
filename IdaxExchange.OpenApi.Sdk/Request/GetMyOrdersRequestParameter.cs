using System.ComponentModel;

namespace IdaxExchange.OpenApi.Sdk.Request
{
    public class GetMyOrdersRequestParameter : BaseRequestParameter
    {
        public int top { get; set; }

        //public long Start { get; set; }

        //public long End { get; set; }
    }
}