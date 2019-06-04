using System.ComponentModel.DataAnnotations;
using IdaxExchange.OpenApi.Sdk.Attributes;

namespace IdaxExchange.OpenApi.Sdk.Enums
{
    public enum OrderSideEnum
    {
        [Translate(Key = "buy")]
        [Display(Name = "buy")]
        Buy = 1,

        [Translate(Key = "sell")]
        [Display(Name = "sell")]
        Sell = 2,

        [Translate(Key = "cancel")]
        [Display(Name = "cancel")]
        Cancel = 3,
    }
}
