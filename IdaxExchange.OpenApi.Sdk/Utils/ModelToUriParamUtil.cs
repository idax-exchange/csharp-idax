using System.Reflection;
using System.Text;
using System.Web;

namespace IdaxExchange.OpenApi.Sdk.Utils
{
    public class ModelToUriParamUtil
    {

      
        public static string ModelToUriParam(object obj, string url = "")
        {
            PropertyInfo[] propertis = obj.GetType().GetProperties();
            StringBuilder sb = new StringBuilder();
            sb.Append(url);
            sb.Append("?");
            foreach (var p in propertis)
            {
                var v = p.GetValue(obj, null);
                if (v == null)
                    continue;

                sb.Append(p.Name.ToLower());
                sb.Append("=");
                sb.Append(HttpUtility.UrlEncode(v.ToString()));
                sb.Append("&");
            }
            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
    }
}
