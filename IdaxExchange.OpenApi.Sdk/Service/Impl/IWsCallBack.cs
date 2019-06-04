using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdaxExchange.OpenApi.Sdk.Service.Impl
{
    public interface IWsCallBack
    {
        /**
         * Called whenever a response comes back from the Idax API.
         *
         * @param response the expected response string
         */
        void onMessage(string result);

    }
}
