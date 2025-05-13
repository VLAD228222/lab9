using System;

class Program
{
    static void Main()
    {
        string[,] months = {
            {"Січень", "31"},
            {"Лютий", "28"},
            {"Березень", "31"},
            {"Квітень", "30"},
            {"Травень", "31"},
            {"Червень", "30"},
            {"Липень", "31"},
            {"Серпень", "31"},
            {"Вересень", "30"},
            {"Жовтень", "31"},
            {"Листопад", "30"},
            {"Грудень", "31"}
        };

        Console.WriteLine("Автор:Дейко Влад");

        while (true)
        {
            Console.WriteLine("\nВведіть номер місяця (1-12), назву місяця або 0 для повної таблиці:");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("\nТаблиця місяців:");
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine($"{i + 1}. {months[i, 0]} - {months[i, 1]} днів");
                }
                break;
            }
            else if (int.TryParse(input, out int monthNum))
            {
                if (monthNum >= 1 && monthNum <= 12)
                {
                    Console.WriteLine($"{months[monthNum - 1, 0]} має {months[monthNum - 1, 1]} днів.");
                    break;
                }
                else
                {
                    Console.WriteLine("Помилка. Неправильний номер місяця. Спробуйте ще раз.");
                }
            }
            else
            {
                bool found = false;
                for (int i = 0; i < 12; i++)
                {
                    if (months[i, 0].Equals(input, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{months[i, 0]} має {months[i, 1]} днів.");
                        found = true;
                        break;
                    }
                }

                if (found)
                    break;
                else
                    Console.WriteLine("Помилка. Місяць не знайдено. Спробуйте ще раз.");
            }
        }

        Console.WriteLine("\nРоботу завершено.");
    }
}
