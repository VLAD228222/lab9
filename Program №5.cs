using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Автор: Дейко Влад");

        string[,] users = {
            {"admin", "admin123"},
            {"user1", "pass1"},
            {"user2", "pass2"}
        };

        Console.Write("Введіть логін: ");
        string login = Console.ReadLine();

        Console.Write("Введіть пароль: ");
        string password = "";
        ConsoleKeyInfo key;

        // Ввід паролю з маскуванням символів
        do
        {
            key = Console.ReadKey(true);
            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                password += key.KeyChar;
                Console.Write("*");
            }
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b");
            }
        } while (key.Key != ConsoleKey.Enter);

        Console.WriteLine();

        bool isAuthenticated = false;
        bool isAdmin = false;

        for (int i = 0; i < users.GetLength(0); i++)
        {
            if (users[i, 0] == login && users[i, 1] == password)
            {
                isAuthenticated = true;
                if (login == "admin") isAdmin = true;
                break;
            }
        }

        if (isAuthenticated)
        {
            Console.WriteLine("Welcome");

            if (isAdmin)
            {
                Console.WriteLine("\nСписок користувачів:");
                for (int i = 0; i < users.GetLength(0); i++)
                {
                    Console.WriteLine($"Логін: {users[i, 0]}, Пароль: {users[i, 1]}");
                }
            }
        }
        else
        {
            Console.WriteLine("Goodbye");
        }
    }
}

