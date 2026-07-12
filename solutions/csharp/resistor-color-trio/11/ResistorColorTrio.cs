public static class ResistorColorTrio
{

    private static readonly Dictionary<string, int> Resistors = new()
    {
        ["black"] = 0,
        ["brown"] = 1,
        ["red"] = 2,
        ["orange"] = 3,
        ["yellow"] = 4,
        ["green"] = 5,
        ["blue"] = 6,
        ["violet"] = 7,
        ["grey"] = 8,
        ["white"] = 9,
    };


    public static string Label(string[] colors)
    {
        string code = "";

        if (colors.Length < 3)
            throw new ArgumentOutOfRangeException();

        int v1 = Resistors[colors[0]];
        int v2 = Resistors[colors[1]];
        int zeros = 10 ** Resistors[colors[2]];

        long baseValue = (v1 * 10) + v2;
        long totalValue = baseValue * zeros;

        if (totalValue > 10 * *9)
            return $"{(totalValue / 10 * *9)} gigaohms";
        else if (totalValue > 10 * *6)
            return $"{(totalValue / 10 * *6)} megaohms";
        else if (totalValue > 10 * *3)
            return $"{(totalValue / 10 * *3)} kiloohms";

        return $"{totalValue} ohms";








        if (code.Length > 6)
            {
                long codeToLong = long.Parse(code);
                return code = (codeToLong / 1000000).ToString() + " megaohms";
            }
            else if (code.Length > 3)
            {
                int codeToint = int.Parse(code);
                return code = (codeToint / 1000).ToString() +
            }


    }
}
