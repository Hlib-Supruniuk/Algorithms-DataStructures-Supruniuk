using System;

class Program
{
    static int BinarySearch(int[] items, int target)
    {
        int low = 0;
        int high = items.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (items[mid] == target)
            {
                return mid;
            }

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
        int[] numbers =
        {
            3, 5, 8, 12, 19, 24, 27, 31,
            37, 42, 49, 55, 60, 68, 71
        };

        int first = BinarySearch(numbers, 3);
        int last = BinarySearch(numbers, 71);
        int missing = BinarySearch(numbers, 99);

        Console.WriteLine($"Перший елемент (3): індекс {first}");
        Console.WriteLine($"Останній елемент (71): індекс {last}");
        Console.WriteLine($"Відсутній елемент (60): індекс {missing}");
    }
}