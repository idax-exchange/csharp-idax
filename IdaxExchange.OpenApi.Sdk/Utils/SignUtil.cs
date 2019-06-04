
namespace IdaxExchange.OpenApi.Sdk.Utils
{
    public class SignUtil
    {
        ///**
        //* getSign
        //*
        //* @param map
        //* @return String
        //*/
        public static string GetSign<T>(T t,string secret)
        {
            var hmacSignedQueryString = new HmacSignedQueryString<T>(t);

            return hmacSignedQueryString.GetHmacSign(secret);
        }
    }
}
