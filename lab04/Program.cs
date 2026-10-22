using System;

class Program
{
    static int comparisons = 0;

    // Лінійний пошук
    static int LinearSearch(int[] items, int target)
    {
        for (int i = 0; i < items.Length; i++)
        {
            comparisons++;

            if (items[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

    // Бінарний пошук
    // Масив повинен бути відсортований за зростанням
    static int BinarySearch(int[] items, int target)
    {
        int low = 0;
        int high = items.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            comparisons++;
            if (items[mid] == target)
            {
                return mid;
            }

            comparisons++;
            if (items[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] sortedData =
        {
            3, 5, 8, 12, 19, 24, 27, 31,
            37, 42, 49, 55, 60, 68, 71
        };

        int[][] testArrays =
        {
            sortedData,
            sortedData,
            sortedData,
            sortedData,
            sortedData,
            sortedData,
            new int[] { 42 },
            new int[] { }
        };

        int[] targets = { 3, 71, 31, 1, 99, 50, 42, 42 };

        string[] cases =
        {
            "Значення стоїть першим",
            "Значення стоїть останнім",
            "Значення посередині",
            "Відсутнє, менше за всі",
            "Відсутнє, більше за всі",
            "Відсутнє, між сусідніми",
            "Масив з одного елемента",
            "Порожній масив"
        };

        for (int i = 0; i < targets.Length; i++)
        {
            Console.WriteLine($"\n{i + 1}. {cases[i]}");
            Console.WriteLine($"Шукаємо: {targets[i]}");

            comparisons = 0;
            int linearIndex =
                LinearSearch(testArrays[i], targets[i]);

            Console.WriteLine(
                $"Лінійний: індекс {linearIndex}, " +
                $"порівнянь {comparisons}");

            comparisons = 0;
            int binaryIndex =
                BinarySearch(testArrays[i], targets[i]);

            Console.WriteLine(
                $"Бінарний: індекс {binaryIndex}, " +
                $"порівнянь {comparisons}");
        }

        // Експеримент: бінарний пошук на невідсортованих даних
        int[] data =
        {
            42, 8, 60, 19, 3, 55, 12, 31,
            68, 24, 49, 37, 71, 5, 27
        };

        comparisons = 0;
        int unsortedIndex = BinarySearch(data, 55);

        Console.WriteLine("\nЕксперимент на невідсортованому масиві");
        Console.WriteLine("Шукаємо: 55");
        Console.WriteLine($"Індекс: {unsortedIndex}");
        Console.WriteLine($"Кількість порівнянь: {comparisons}");
    }
}