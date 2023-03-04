Console.Clear();
Console.WriteLine("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

int A = ReadNumber("Введите число: ");
PrintResult(A);


static int ReadNumber(string message)
{
    int n = 0;
    while (true)
    {
        try
        {
            Console.WriteLine(message);
            n = int.Parse(Console.ReadLine() ?? "");
            if (n > 1) break;
            else Console.WriteLine("Ошибка ввода! Введите число больше 1!");
        }
        catch (Exception exc)
        {
            Console.WriteLine("Ошибка ввода! Введите число!");
        }
    }
    return n;
}

static double Result(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double ress = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return ress;
}

static void PrintResult(int A)
{
    Console.Write($"{A} -> ");
    for (int i = 1; i <= A; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}

