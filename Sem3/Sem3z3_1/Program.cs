//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.
// -------------------------- Начало программы ----------------------------------
Console.Clear();
int num = ReadNumber("Введите номер четверти ");
PrintResult(num);

static void PrintResult(int num)
{
    if (num == 1)
        Console.WriteLine("x > 0 и y > 0");
    else if (num == 2)
        Console.WriteLine("x < 0 и y > 0");
    else if (num == 3)
        Console.WriteLine("x < 0 и y < 0");
    else Console.WriteLine("x > 0 и y < 0");
}

static int ReadNumber(string message)
{
    int n = 0;
    while (true)
    {
        try
        {
            Console.WriteLine(message);
            n = int.Parse(Console.ReadLine() ?? "");
            if (n>0 && n<5){
                break;
            }
            else{Console.WriteLine("Ошибка ввода, такой четверти не сущ");}
        }
        catch (Exception exc)
        {
            Console.WriteLine("Ошибка ввода! Введите число!");
        }
    }
    return n;
}
