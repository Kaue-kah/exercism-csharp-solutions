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
        return _list.Min();
    }

    public int PersonalBest()
    {
        return _list.Max();
    }

    public List<int> PersonalTopThree()
    {
        List<int> topThree = new List<int>();
        List<int> baseList = _list;

        for (var i = 0; i < 3; i++)
        {
            int max = baseList.Max();
            baseList.Remove(max);
            topThree.Add(max);
        }

        return topThree; 
    }
}