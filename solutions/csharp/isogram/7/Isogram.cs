public static class Isogram
{

    public static bool IsIsogram(string word)
    {
        List<char> letras = new List<char>();

        foreach (char c in word.ToLower())
        {
            if (!char.IsLetter(c))
                continue;

            if (letras.Contains(c)) 
                return false;

            letras.Add(c);
        }

        return true;
    }
}
