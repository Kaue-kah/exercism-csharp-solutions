using System.Runtime.Serialization.Formatters;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        double totalSum = 0;

        if (max < 0)
            throw new ArgumentOutOfRangeException();

        for (var i = 1; i <= max; i++)
        {
            totalSum += i;
        }

        return (int) Math.Pow(totalSum, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        int total = 0;

        if (max < 0)
            throw new ArgumentOutOfRangeException();

        for (var i = 1; i <= max; i++)
        {
            total += (int) Math.Pow(i, 2);
        }

        return total;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateDifferenceOfSquares(max);
    }
}