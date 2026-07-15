public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {

        List<(int, int, int)> results = new();

        int limit = (int)sum / 3;

        for (int a = 1; a <= limit; a++)
        {
            int numerator = sum * (sum - 2 * a);
            int denominator = (2 * (sum - a));

            if (numerator % denominator == 0)
            {
                int b = numerator / denominator;
                int c = sum - (a + b);
                (int, int, int) currentTriangle = (a, b, c);

                if ((a < b) && (b < c))
                {
                    if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
                    {
                        results.Add(currentTriangle);
                    }
                }
            }
        }

        return results.ToArray();
    }
}