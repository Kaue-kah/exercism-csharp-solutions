using System.Diagnostics.Metrics;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int steps = 0;

        if (number <= 0)
            return throw new ArgumentOutOfRangeException;

        while (number != 1)
        {
            steps++;

            if (number % 2 == 0)
                number = number / 2;
            else
                number = number * 3 + 1;
        }

        return steps;
    }
}