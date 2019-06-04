using System;
using Newtonsoft.Json;

namespace IdaxExchange.OpenApi.Sdk.Utils
{
    public class JsonUtil
    {
        public static string ToJsonStringRemoveNull(object input)
        {
            if (input == null)
                return string.Empty;
            var jsonSetting = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            return JsonConvert.SerializeObject(input, Formatting.Indented, jsonSetting);
        }

        public static T ToObject<T>(string jsonString)
        {
            try
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    return default(T);
                }

                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            catch (Exception e)
            {
                // Logger.Info("======Deserialize======="+e);
                return default(T);
            }
        }
    }
}
