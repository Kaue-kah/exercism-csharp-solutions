public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        return moment.AddSeconds(1 * Math.Pow(10, 9));
    }
}