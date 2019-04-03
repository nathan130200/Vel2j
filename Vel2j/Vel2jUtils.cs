using System;

public static class Vel2jUtils
{
    public static readonly DateTimeOffset EPOCH = new DateTimeOffset(2019, 01, 01, 0, 0, 0, TimeSpan.FromHours(-3));

    public static long GetUniqueId()
    {
        return (long)DateTimeOffset.Now.Subtract(EPOCH)
            .TotalSeconds;
    }
}
