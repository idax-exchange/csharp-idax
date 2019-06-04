using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace IdaxExchange.OpenApi.Sdk.Utils
{
    public static class HmacUtil
    {
        public static string HmacSha256(string input, string secret)
        {
            using (var provider = new HMACSHA256(Encoding.UTF8.GetBytes(secret)))
            {
                var hashedPassword = provider.ComputeHash(Encoding.Default.GetBytes(input));
                var sb = new StringBuilder();
                foreach (byte t in hashedPassword)
                {
                    sb.Append(t.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }

    public class HmacSignedQueryString<T> : SortedDictionary<string, string>
    {
        public HmacSignedQueryString(IEnumerable<KeyValuePair<string, string>> keyValuePairs)
        {
            foreach (var keyValuePair in keyValuePairs)
            {
                if (this.ContainsKey(keyValuePair.Key))
                {
                    throw new Exception($"parameter {keyValuePair.Key} appears two times!");
                }
                this.Add(keyValuePair.Key, keyValuePair.Value);
            }
        }
        public HmacSignedQueryString(T t)
        {

            var propertis = t.GetType().GetProperties();
            var sb = new StringBuilder();
            foreach (var p in propertis)
            {
                var v = p.GetValue(t, null);
                if (v == null)
                    continue;
                Add(p.Name, v.ToString());
            }

            
            
        }
        
        private string GetSortedQueryString()
        {
            var list = new List<string>();

            foreach (var keyvaluepair in this)
            {
                if (keyvaluepair.Key != "sign")
                {
                    list.Add($"{keyvaluepair.Key}={keyvaluepair.Value}");
                }
            }

            return string.Join("&", list);
        }


        public string GetHmacSign(string secret)
        {
            var queryString = GetSortedQueryString();
            return HmacUtil.HmacSha256(queryString, secret);
        }


        public bool IsVerified(string secret)
        {
            var sign = this.FirstOrDefault(x => x.Key == "sign").Value;

            return GetHmacSign(secret) == sign;
        }


        public static Dictionary<string, string> GetProperties<T>(T t)
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();

            if (t == null)
            {
                return null;
            }
            PropertyInfo[] properties = t.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            if (properties.Length <= 0)
            {
                return null;
            }
            foreach (PropertyInfo item in properties)
            {
                string name = item.Name;                                              
                string value = item.GetValue(t, null).ToString();                

                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    ret.Add(name, value);        
                }
            }

            return ret;
        }

    }
}
