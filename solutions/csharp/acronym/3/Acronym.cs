public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] delimiterChars = [' ', '-'];
        string[] words = phrase.Split(delimiterChars);

        string abrev = "";

        foreach (string word in words)
        {
            if (char.IsLetter(word[0]))    
                abrev += word[0];
        }


        return abrev.ToUpper();

    }
}