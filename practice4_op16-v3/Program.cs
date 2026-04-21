static void Triangle(char symbol, int rows)
{
    for (int i = 1; i <= rows; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write($"{symbol} ");
        }
        Console.WriteLine();
    }
}

//char s = '$';

Console.Write("Введите символ: ");
char symbol = Console.ReadKey().KeyChar;

Console.WriteLine("\n");

int rows;

Console.Write("Введите количество строк (1-20): ");

while (true)
{
    if (!int.TryParse(Console.ReadLine(), out rows))
    {
        Console.Write("Ошибка ввода. Попробуйте снова: ");
        continue;
    }
    if (rows <= 0 || rows > 20)
    {
        Console.Write("Пожалуйста, введите число от 1 до 20: ");
        continue;
    }
    break;
}


Triangle(symbol, rows);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nНажмите для завершения. . .");
Console.ResetColor();
Console.ReadKey();
