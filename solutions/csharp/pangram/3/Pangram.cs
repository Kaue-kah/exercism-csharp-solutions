public static class Pangram
{

    static string alphabet = "abcdefghijklmnopqrstuvwxyz";

    public static bool IsPangram(string input)
    {
        input = input.ToLower();
        
        foreach (char c in alphabet)
        {
            if (input.IndexOf(c) == -1)
            {
                return false;
            }
        }

        return true;
    }
}
