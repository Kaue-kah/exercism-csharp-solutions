public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        var pairs = new Dictionary<char, char> { [')'] = '(', [']'] = '[', ['}'] = '{' };
        Stack<char> pilha = new();


        foreach (char c in texto)
        {
            if ("([{".Contains(c))
                pilha.Push(c);
            else if (")]}".Contains(c))
            {
                if (pilha.Count == 0 || pilha.Peek() != pairs[c])
                {
                    return false;
                }
                pilha.Pop();
            }
        }

        return (pilha.Count == 0) ? true : false;
    }
}
