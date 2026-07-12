public static class Isogram
{

    public static bool IsIsogram(string word)
    {
        List<char> letras = new List<char>();
        word = word.ToLower();
        word = word.Trim();

        foreach (char c in word)
        {
            if (letras.Contains(c) && c != '-' && c != " ") 
                return false;

            letras.Add(c);
        }

        return true;
    }
}
