using System;

namespace IdaxExchange.OpenApi.Sdk.Utils
{
    public static class DateTimeExtensions
    {
        public static readonly DateTime UnixDateTimeStartPoint = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static long UnixTimeStamp(this DateTime datetime)
        {
            return (long)(datetime.ToUniversalTime() - UnixDateTimeStartPoint).TotalMilliseconds;
        }
    }
}
