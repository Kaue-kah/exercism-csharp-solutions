public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        List<U> values = new();

        foreach (var x in collection)
        {
            U newValue = func(x);
            values.Add(newValue);
        }

        return values;
    }
}