using System.ComponentModel.DataAnnotations;

namespace IdaxExchange.OpenApi.Sdk.Enums
{
    public enum PeriodEnum
    {

        /**
         * 1min
         */
        [Display(Name = "1min")]
        ONE_MINUTE,

        /**
         * 5min
         */
        [Display(Name = "5min")]
        FIVE_MINUTE,

        /**
         * 15min
         */
        [Display(Name = "15min")]
        FIFTEEN_MINUTE,

        /**
         * 30min
         */
        [Display(Name = "30min")]
        THIRTY_MINUTE,

        /**
         * 1hour
         */
        [Display(Name = "1hour")]
        ONE_HOUR,

        /**
         * 2hour
         */
        [Display(Name = "2hour")]
        TWO_HOUR,

        /**
         * 4hour
         */
        [Display(Name = "4hour")]
        FOUR_HOUR,

        /**
         * 6hour
         */
        [Display(Name = "6hour")]
        SIX_HOUR,

        /**
         * 12hour
         */
        [Display(Name = "12hour")]
        TWELVE_HOUR,

        /**
         * 1day
         */
        [Display(Name = "1day")]
        ONE_DAY,

        /**
         * 1week
         */
        [Display(Name = "1week")]
        ONE_WEEK

        ///**
        // * code
        // */
        //private String code;
        ///**
        // * desc
        // */
        //private String desc;
    }
}
