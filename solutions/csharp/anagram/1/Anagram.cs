public class Anagram
{
    private string _anagram;

    public Anagram(string baseWord)
    {
        _anagram = baseWord.ToLower(); 
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> Anagrams = new();
        
        foreach (var word in potentialMatches)
        {
            bool isAnagram = true;

            if (String.IsNullOrEmpty(word))
                continue;

            string useWord = word.ToLower();

            if (useWord == _anagram)
                continue;

            if (useWord.Length != _anagram.Length)
                continue;

            char[] letters = useWord.ToCharArray();
            Array.Sort(letters);

            char[] anagramLetters = _anagram.ToCharArray();
            Array.Sort(anagramLetters);
            

            for(var i = 0; i < letters.Length; i++)
            {
                if (letters[i] != anagramLetters[i])
                    isAnagram = false;
            }


            if (isAnagram) Anagrams.Add(word);
       
        }
        
        return Anagrams.ToArray();
    }
}