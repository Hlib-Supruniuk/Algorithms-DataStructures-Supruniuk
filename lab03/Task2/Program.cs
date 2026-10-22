using System;

class Program
{
    static void Main()
    {
        (int Month, decimal Amount)[] operations =
        {
            (1, 1200m),
            (1, 300m),
            (3, 750m),
            (5, 200m),
            (12, 1600m),
            (3, 250m)
        };

        decimal[] monthlyTotals = new decimal[12];

        foreach (var operation in operations)
        {
            monthlyTotals[operation.Month - 1] += operation.Amount;
        }

        Console.WriteLine("Підсумки за місяцями:");

        for (int i = 0; i < monthlyTotals.Length; i++)
        {
            Console.WriteLine($"Місяць {i + 1}: {monthlyTotals[i]}");
        }
    }
}