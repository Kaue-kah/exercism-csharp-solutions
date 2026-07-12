public static class Grains
{
    public static ulong Square(int n)
    {
        ulong quantidade;
        quantidade = (ulong) Math.Pow(2, n-1);
        return quantidade;

    }

    public static ulong Total()
    {
        return (ulong)Math.Pow(2, 63);
    }
}