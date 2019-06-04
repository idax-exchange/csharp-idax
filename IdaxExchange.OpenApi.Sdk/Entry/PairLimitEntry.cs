using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Entry
{
    [Serializable]
    public class PairLimitEntry : BaseEntry
    {
        /**
         * Pair Limit
         */
        [JsonProperty(PropertyName = "pairRuleVo")]
        private List<PairRule> pairRuleVo;
    }
}
