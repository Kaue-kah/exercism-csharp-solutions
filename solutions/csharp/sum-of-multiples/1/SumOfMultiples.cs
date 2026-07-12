public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> nums = new();
        int total = 0;

        foreach (var multiple in multiples)
        {
            for (var i = 1; i<max; i++)
            {
                if (i % multiple == 0)
                    nums.Add(i);
            }    
        }

        var numsNoRepeat = nums.Distinct().ToList();

        foreach (var num in numsNoRepeat)
        {
            total += num;
        }

        return total;
    }
}