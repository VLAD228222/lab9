using System;

namespace MatrixAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Автор проєкту: Дейко Влад"); 
            Console.WriteLine();

            Console.Write("Введіть кількість рядків матриці: ");
            int rows = ReadPositiveInt();

            Console.Write("Введіть кількість стовпців матриці: ");
            int cols = ReadPositiveInt();

            int[,] matrix = new int[rows, cols];
            Random rand = new Random();

            int sum = 0;
            Console.WriteLine("\nЗгенерована матриця:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 101);
                    sum += matrix[i, j];
                    Console.Write(matrix[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }

            double average = (double)sum / (rows * cols);
            int countAboveAverage = 0;

            foreach (int num in matrix)
            {
                if (num > average) countAboveAverage++;
            }

            Console.WriteLine($"\nСереднє арифметичне: {average:F2}");
            Console.WriteLine($"Кількість елементів, більших за середнє: {countAboveAverage}");

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

