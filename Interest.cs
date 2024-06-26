//task:https://exercism.org/tracks/csharp/exercises/interest-is-interesting
using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
            return 3.213f;
        else if (balance < 1000)
            return 0.5f;
        else if (balance >= 1000 && balance < 5000)
            return 1.621f;
        else
            return 2.475f;
    }

    public static decimal Interest(decimal balance)
    {
        return balance / 100 * (decimal)InterestRate(balance);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int yearsToTarget = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            yearsToTarget++;
        }
        return yearsToTarget;
    }
}