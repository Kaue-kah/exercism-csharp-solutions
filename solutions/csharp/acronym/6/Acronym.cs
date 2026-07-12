public static class Acronym
{
    public static string Abbreviate(string phrase)
    {

        char[] delimiterChars = ['-', '_'];
        phrase = phrase.Replace(delimiterChars, ' ');
        string[] words = phrase.Split(' ');

        string abrev = "";

        foreach (string word in words)
        {
            word = word.Trim();

            if (char.IsLetter(word[0]))    
                abrev += word[0];
        }

        return abrev.ToUpper();

    }
}