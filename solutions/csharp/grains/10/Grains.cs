public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0 || n>64)
            throw new ArgumentOutOfRangeException();

        ulong quantidade;
        quantidade = (ulong) Math.Pow(2, n-1);
        return quantidade;

    }

    public static ulong Total()
    {
        ulong total = 0;

        for(var i = 0; i < 64; i++)
        {
            total += (ulong) Math.Pow(2, i);
        }

        return total;
    }
}