public static class Darts
{
    public static int Score(double x, double y)
    {
        int score = 0;
        double sumOfSquares = Math.Pow(x, 2) + Math.Pow(y, 2);
        double distance = Math.Sqrt(sumOfSquares);

        if (distance <= 1)
            return 10;
        else if (distance <= 5)
            return 5;
        else if (distance <= 10)
            return 1;

        return score;
    }
}
