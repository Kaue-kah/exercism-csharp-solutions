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

        for (var i = 0; i < 2; i++)
        {
            code += Resistors[colors[i]].ToString();
        }

        int addZero = (int.Parse(code) * Math.Pow(Resistors[colors[2]], 2));
        code += addZero.ToString();


        return code;


    }
}
