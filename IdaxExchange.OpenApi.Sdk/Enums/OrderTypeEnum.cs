using System.ComponentModel.DataAnnotations;

namespace IdaxExchange.OpenApi.Sdk.Enums
{
    public enum OrderTypeEnum
    {
        [Display(Name = "limit")]
        Limit = 1,
        [Display(Name = "market")]
        Market = 2
    }
}
