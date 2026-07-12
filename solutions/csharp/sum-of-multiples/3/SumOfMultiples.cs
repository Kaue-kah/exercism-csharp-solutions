public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> nums = new();
        
        foreach (var multiple in multiples)
        {
            if (multiple <= 0)
            {
                continue;
            }

            for (var i = 1; i<max; i++)
            {
                if (i % multiple == 0)
                    nums.Add(i);
            }    
        }

        var numsNoRepeat = nums.Distinct().ToList();

        return nums.Sum();
    }
}