using System;

namespace IdaxExchange.OpenApi.Sdk.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class TranslateAttribute : Attribute
    {
        public string Key { get; set; }
    }
}
