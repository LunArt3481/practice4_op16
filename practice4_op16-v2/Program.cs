int a = 100;
int b = 13;

static int? simple(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            count++;
        }   
    }
    if (count == 2)
    {
        return num;
    }
    else
    {
        return 0;
    }
}

int simple_count = 0;

for(int i = 100; i <1000; i++)
{
    if (simple(i) != 0)
    {
        simple_count++;
    }
}

int[] massive = new int[simple_count];
int count = 0;

for (int i = 100; i < 1000; i++)
{
    if (simple(i) != 0)
    {
        massive[count] = Convert.ToInt32(simple(i));
        count++;
    }
}

count = 1;

foreach (int i in massive)
{
    Console.Write(i + " ");
    count++;
    if(count == 8)
    {
        Console.WriteLine();
        count = 1;
    }
}

Console.WriteLine("\n");
Console.WriteLine($"Трёхзначных простых чисел всего {simple_count}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nНажмите для завершения. . .");
Console.ResetColor();
Console.ReadKey();