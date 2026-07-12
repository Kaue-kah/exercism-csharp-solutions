class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var i in birdsPerDay)
        {
            if (i == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        //4
        var sum = 0;
        if (numberOfDays > birdsPerDay.Length)
        {
            numberOfDays = birdsPerDay.Length; 
        }

        for (var i = 0; i < numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        }

        return sum;
    }

    public int BusyDays()
    {
        int totalDays = 0;

        foreach (var i in birdsPerDay)
        {
            if (i >= 5) totalDays++;
        }

        return totalDays;
    }
}
