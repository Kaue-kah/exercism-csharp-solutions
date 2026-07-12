static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        switch (balance)
        {
            case < 0:
                return 3.213f;
            case < 1000m:
                return 0.5f;
            case >= 1000m and < 5000m:
                return 1.621f;
            case >= 5000m:
                return 2.475f;
            default:
                return 0;
        }
    }

    public static decimal Interest(decimal balance)
    {
        return ((decimal)InterestRate(balance) / 100) * balance;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int totalYears = 0;

        decimal currentBalance = balance;

        while (targetBalance > currentBalance)
        {
            totalYears++;
            currentBalance = AnnualBalanceUpdate(currentBalance);
        }

        return totalYears;
    }
}
