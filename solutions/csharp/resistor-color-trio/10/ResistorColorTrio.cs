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

        for (var i = 0; i < Resistors[colors[2]]; i++)
        {
            code += '0';
        }


        if (code.Length > 6)
        {
            long codeToLong = long.Parse(code);
            return code = (codeToLong / 1000000).ToString() + " megaohms";
        }
        else if(code.Length > 3)
        {
            int codeToint = int.Parse(code);
            return code = (codeToint / 1000).ToString() + " kiloohms";
        }
        else
        {
            return int.Parse(code) + " ohms";
        }

    }
}
