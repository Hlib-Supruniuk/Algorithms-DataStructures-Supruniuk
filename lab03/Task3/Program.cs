using System;

class Program
{
    static void Main()
    {
        const int N = 5;

        string[] events = new string[N];
        int next = 0;
        int count = 0;

        string[] incomingEvents =
        {
            "Подія 1",
            "Подія 2",
            "Подія 3",
            "Подія 4",
            "Подія 5",
            "Подія 6",
            "Подія 7"
        };

        foreach (string item in incomingEvents)
        {
            events[next] = item;
            next = (next + 1) % N;

            if (count < N)
            {
                count++;
            }
        }

        Console.WriteLine("Останні події від найстарішої до найновішої:");

        int start = count == N ? next : 0;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(events[(start + i) % N]);
        }
    }
}