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

        if (colors[2] == "black")
            code += " ohms";

        if (colors[2] == "orange")
            code += " kiloohms";


        return code;


    }
}
