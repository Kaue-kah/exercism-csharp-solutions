public static class Pangram
{

    static string alphabet = "abcdefghijklmnopqrstuv";

    public static bool IsPangram(string input)
    {
        foreach (char c in alphabet)
        {
            var i = input.IndexOf(c);

            if (i == -1)
            {
                return false;
            }
        }

        return true;
    }
}
