
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> journal = new List<string>();

        journal.Add("Запуск програми");
        journal.Add("Вхід користувача");
        journal.Add("Відкриття файлу");
        journal.Add("Збереження змін");
        journal.Add("Завершення роботи");

        journal.Reverse();

        Console.WriteLine("Журнал у зворотному порядку:");

        foreach (string entry in journal)
        {
            Console.WriteLine(entry);
        }
    }
}