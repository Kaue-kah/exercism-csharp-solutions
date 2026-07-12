public static class Acronym
{
    public static string Abbreviate(string phrase)
    {

        char[] delimiterChars = ['-', '_'];
        phrase = phrase.Replace('-', ' ').Replace('_', ' ');
        string[] words = phrase.Split(' ');

        string abrev = "";

        foreach (string word in words)
        {
            string wordTrim = word.Trim();

            if (wordTrim.Length > 0 && 
                char.IsLetter(wordTrim[0]))    
                abrev += wordTrim[0];
        }

        return abrev.ToUpper();

    }
}