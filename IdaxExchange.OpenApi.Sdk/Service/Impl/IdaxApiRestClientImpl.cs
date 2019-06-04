using System;
using System.Collections.Generic;
using IdaxExchange.OpenApi.Sdk.Constant;
using IdaxExchange.OpenApi.Sdk.Entry;
using IdaxExchange.OpenApi.Sdk.Request;
using IdaxExchange.OpenApi.Sdk.Utils;
using Newtonsoft.Json;
using RestSharp;

namespace IdaxExchange.OpenApi.Sdk.Service.Impl
{
    public class IdaxApiRestClientImpl: IdaxApiRestClient
    {
        private readonly string apiKey;
        private readonly string secret;
        private readonly string apiBaseUrl;
        
     
        public IdaxApiRestClientImpl(string apiKey, string secret, string apiBaseUrl)
        {
            this.apiKey = apiKey;
            this.secret = secret;
            this.apiBaseUrl = apiBaseUrl;
        }
        
       
        public OrderBookEntry getOrderBook(string pairName)
        {
            string url = apiBaseUrl + IdaxApiConstants.URL_DEPTH.Replace("#{symbol}",pairName);
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var model= JsonConvert.DeserializeObject<OrderBookEntry>(response.Content);
            return model;
        }

        public TickerEntry getTickerEntry(string pairName)
        {
            string url = apiBaseUrl + IdaxApiConstants.URL_TICKER.Replace("#{symbol}", pairName);
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var model = JsonConvert.DeserializeObject<TickerEntry>(response.Content);
            return model;
        }

        public KlineEntry getKlineEntry(KlineRequest param)
        {
         
            string url = ModelToUriParamUtil.ModelToUriParam(param, apiBaseUrl + IdaxApiConstants.URL_K_LINE);
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var model = JsonConvert.DeserializeObject<KlineEntry>(response.Content);
            return model;
        }

        public TradeEntry getTradeEntry(string pairName)
        {
            string url = apiBaseUrl + IdaxApiConstants.URL_TRADE.Replace("#{symbol}", pairName);
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var model = JsonConvert.DeserializeObject <TradeEntry> (response.Content);
            return model;
        }

        public PairEntry getPairEntry()
        {
            string url = apiBaseUrl + IdaxApiConstants.URL_PAIR;
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var model = JsonConvert.DeserializeObject<PairEntry>(response.Content);
            return model;
        }

        public PairLimitEntry getPairLimitEntry(string pairName)
        {
            string url = apiBaseUrl + IdaxApiConstants.URL_PAIR_LIMIT.Replace("#{symbol}", pairName);
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var model = JsonConvert.DeserializeObject<PairLimitEntry>(response.Content);
            return model;
        }

        public OrderInfoEntry getOrderInfo(OrderInfoRequest param)
        {
            param.sign = SignUtil.GetSign(param, secret);

            string url = apiBaseUrl + IdaxApiConstants.URL_ORDER_INFO;
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(param), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var model = JsonConvert.DeserializeObject<OrderInfoEntry>(response.Content);
            return model;
        }

        public OrderHistoryEntry getOrderHistory(OrderHistoryRequest param)
        {
            param.sign = SignUtil.GetSign(param, secret);

            string url = apiBaseUrl + IdaxApiConstants.URL_ORDER_HISTORY;
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(param), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var model = JsonConvert.DeserializeObject<OrderHistoryEntry>(response.Content);
            return model;
        }

        public UserInfoEntry getUserInfo(UserInfoRequest param)
        {
            param.sign = SignUtil.GetSign(param, secret);

            string url = apiBaseUrl + IdaxApiConstants.URL_USER_INFO;
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(param), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var model = JsonConvert.DeserializeObject<UserInfoEntry>(response.Content);
            return model;
        }

        public MyTradesResultEntry getMyTrades(MyTradesRequest param)
        {
            param.sign = SignUtil.GetSign(param, secret);

            string url = apiBaseUrl + IdaxApiConstants.URL_MY_TRADES;
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(param), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var model = JsonConvert.DeserializeObject<MyTradesResultEntry>(response.Content);
            return model;
        }

        public PlaceOrderEntry placeOrder(PlaceOrderRequest param)
        {
            param.sign = SignUtil.GetSign(param, secret);

            string url = apiBaseUrl + IdaxApiConstants.URL_PLACE_ORDER;
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(param), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var model = JsonConvert.DeserializeObject<PlaceOrderEntry>(response.Content);
            return model;
        }
        
        
        public CancelOrderEntry cancelOrder(CancelOrderRequest param)
        {

            param.sign = SignUtil.GetSign(param,secret);

            string url = apiBaseUrl + IdaxApiConstants.URL_CANCEL_ORDER;
            Uri baseUrl = new Uri(url);
            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(Method.POST);
            request.AddParameter("application/json", JsonConvert.SerializeObject(param), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var model = JsonConvert.DeserializeObject<CancelOrderEntry>(response.Content);
            return model;
        }

        
    }
}
