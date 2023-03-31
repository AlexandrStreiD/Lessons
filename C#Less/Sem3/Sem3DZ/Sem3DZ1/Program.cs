Console.Clear();
Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
int A = ReadNumber("Введите пятизначное число: ");
PrintResult(A, Result(A));

static int ReadNumber(string message)
{
    int n = 0;
    while (true)
    {
        try
        {
            Console.WriteLine(message);
            n = int.Parse(Console.ReadLine() ?? "");
            if (n > 9999 && n < 100000) break;
            else Console.WriteLine("Ошибка ввода! Введите пятизначное число!");
        }
        catch (Exception exc)
        {
            Console.WriteLine("Ошибка ввода! Введите число!");
        }
    }
    return n;
}

static bool Result(int A)
{
    int z1 = A % 10;
    int z2 = (A / 10) % 10;
    int z3 = (A / 100) % 10;
    int z4 = (A / 1000) % 10;
    int z5 = (A / 10000) % 10;
    //Console.WriteLine($"{z1},{z2},{z3},{z4},{z5}");
    if (z1 == z5 && z2 == z4)
    {
        return true;
    }
    else
    {
        return false;
    }

}
 
static void PrintResult(int A, bool A1)
{
    if (A1 == true) { Console.WriteLine($"{A} -> ДА"); }
    else { Console.WriteLine($"{A} -> НЕТ"); }
}
