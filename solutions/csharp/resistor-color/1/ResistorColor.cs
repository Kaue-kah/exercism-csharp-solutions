public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] colors = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        for (int i = 0; i < colors.Length; i++)
        {
            if (colors[i] == color) return i;
        }

        return -1;
    
    }

    public static string[] Colors()
    {
        return ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" ];
    }
}