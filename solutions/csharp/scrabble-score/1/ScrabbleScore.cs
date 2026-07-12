public static class ScrabbleScore
{
    
    private static Dictionary<char, int> scores = new();


    static ScrabbleScore()
    {
        foreach (char c in "AEIOULNRST")
            scores[c] = 1;

        foreach (char c in "DG")
            scores[c] = 2;

        foreach (char c in "BCMP")
            scores[c] = 3;

        foreach (char c in "FHVWY")
            scores[c] = 4;

        scores['K'] = 5;

        foreach (char c in "JX")
            scores[c] = 8;

        foreach (char c in "QZ")
            scores[c] = 10;
    }


    public static int Score(string input)
    {
        if (string.IsNullOrEmpty(input)) return 0;

        int total = 0;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
                total += scores[char.ToUpper(c)];
        }

        return total;
    }
}