using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Автор проєкту: Дейко Влад\n");

            Console.Write("Введіть кількість спортсменів: ");
            int n = ReadPositiveInt();

            Console.Write("Введіть кількість стрибків кожного спортсмена: ");
            int m = ReadPositiveInt();

            int[,] results = new int[n, m];
            Random rand = new Random();

            Console.WriteLine("\nТаблиця результатів (в метрах):");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Спортсмен {i + 1}: ");
                for (int j = 0; j < m; j++)
                {
                    results[i, j] = rand.Next(5, 10); // умовно: стрибки від 5 до 9 метрів
                    Console.Write($"{results[i, j]}м ");
                }
                Console.WriteLine();
            }

            int maxTotal = 0;
            int winnerIndex = 0;

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += results[i, j];
                }

                if (sum > maxTotal)
                {
                    maxTotal = sum;
                    winnerIndex = i;
                }
            }

            Console.WriteLine($"\nПереможець: Спортсмен {winnerIndex + 1}");
            Console.WriteLine($"Його результат: {maxTotal} метрів");

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }

        static int ReadPositiveInt()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.Write("Помилка! Введіть додатне ціле число: ");
            }
            return value;
        }
    }
}
