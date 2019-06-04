using System.ComponentModel.DataAnnotations;

namespace IdaxExchange.OpenApi.Sdk.Enums
{

    public enum EventTypeEnum
    {
        [Display(Name = "addChannel")]
        ADD_CHANNEL = 1,
        [Display(Name = "updateChannel")]
        UPDATE_CHANNEL = 2
    }
}
