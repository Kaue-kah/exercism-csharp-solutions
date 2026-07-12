public static class Bob
{
    public static string Response(string statement)
    {
        if (isSilence(statement))
            return "Fine. Be that way!";
        else if (isAQuestion(statement) && itsScream(statement))
            return "Calm down, I know what I'm doing!";
        else if (isAQuestion(statement))
            return "Sure.";
        else if (itsScream(statement))
            return "Whoa, chill out!";
        else
            return "Whatever.";

    }


    public static bool isAQuestion(string frase)
    {
        int index = frase.Length;
        if (frase[index - 1] == '?')
            return true;

        return false;
    }


    public static bool itsScream(string frase)
    {
        frase = frase.Trim();
        foreach (char c in frase)
        {
            if (char.IsLower(c))
                return false;
        }

        return true;
    }


    public static bool isSilence(string frase)
    {
        if ((frase.Trim() == "") || (frase == null))
            return true;

        return false;
    }


}









