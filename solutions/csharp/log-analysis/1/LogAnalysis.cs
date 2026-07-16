public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter);

        if (index == -1)
            return String.Empty;

        int startIndex = index + delimiter.Length;
        return str.Substring(startIndex);

    }

    public static string SubstringBetween(this string str, string delimiter1, string delimiter2)
    {
        int index1 = str.IndexOf(delimiter1);
        if (index1 == -1) return String.Empty;

        string word = str.SubstringAfter(delimiter1);

        int index2 = word.LastIndexOf(delimiter2);
        if (index2 == -1) return String.Empty;

        return word.Substring(0, index2);
    }

    public static string Message(this string str)
    {
        if (str.SubstringBetween("[", "]") == String.Empty)
            return String.Empty;

        return str.SubstringAfter(":").Trim();
    }

    public static string LogLevel(this string str)
    {
        return (str.SubstringBetween("[", "]") == String.Empty) ?
            String.Empty : str.SubstringBetween("[", "]").Trim();
    }
}