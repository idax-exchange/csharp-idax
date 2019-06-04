using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
    [Serializable]
    public class PairRule
    {
        /**
         * Ticker symbol.
         */
        [JsonProperty(PropertyName = "pairName")]
        public string pairName { get; set; }

        /**
         * maxAmount.
         */
        [JsonProperty(PropertyName = "maxAmount")]
        public string maxAmount { get; set; }

        /**
         * minAmount.
         */
        [JsonProperty(PropertyName = "minAmount")]
        public string minAmount { get; set; }

        /**
         * The price small digital.
         */
        [JsonProperty(PropertyName = "priceDecimalPlace")]
        public int priceDecimalPlace { get; set; }

        /**
         * Number of decimal places.
         */
        [JsonProperty(PropertyName = "qtyDecimalPlace")]
        public int qtyDecimalPlace { get; set; }
    }
}
