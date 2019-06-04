using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace IdaxExchange.OpenApi.Sdk.Utils
{
    public static class ReflectionUtil
    {
        public static string GetDisplayAttribute(this Enum obj)
        {
            var fields = obj.GetType().GetFields();

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var fieldInfo in fields)
            {
                if (!fieldInfo.GetValue(obj).Equals(obj)) continue;

                var displayAttribute
                    = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false).First() as DisplayAttribute;
                return displayAttribute?.Name;
            }

            return null;
        }
    }
}
