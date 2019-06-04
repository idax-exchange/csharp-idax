using System.ComponentModel.DataAnnotations;

namespace IdaxExchange.OpenApi.Sdk.Enums
{
    public enum DepthYEnum
    {
        [Display(Name = "5")]
        FIVE = 5,
        [Display(Name = "10")]
        TEN = 10,
        [Display(Name = "20")]
        TWENTY = 20,
        [Display(Name = "50")]
        FIFTY = 50
    }
}
