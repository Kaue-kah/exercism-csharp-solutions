public class HighScores
{

    private List<int> _list = new List<int>();

    public HighScores(List<int> list)
    {
        _list = list;
    }

    public List<int> Scores()
    {
        return _list;
    }

    public int Latest()
    {
        return _list.Last();
    }

    public int PersonalBest()
    {
        return _list.Max();
    }

    public List<int> PersonalTopThree()
    {
        List<int> topThree = new List<int>();
        List<int> baseList = _list;
        int numberRange = baseList.Count();

        if (baseList.Count >= 3{
            numberRange = 3;
        }

        for (var i = 0; i < numberRange; i++)
        {
            int max = baseList.Max();
            baseList.Remove(max);
            topThree.Add(max);
        }

        return topThree; 
    }
}