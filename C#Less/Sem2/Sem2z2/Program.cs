Console.Clear();
Console.WriteLine("\n\n\n");
Console.WriteLine("Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число не кратно числу 1, то программа выводит остаток от деления.");
Console.WriteLine("");
Console.WriteLine("Введите первое целое число X: ");
int x = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе целое число Y: ");
int y = int.Parse(Console.ReadLine() ?? "");
if (x % y == 0)
{
    Console.WriteLine($"Первое число {x}, второе число {y} -> КРАТНО");
}
else
{   int z = x % y;
    //int z = x - (x / y * y);
    Console.WriteLine($"Первое число {x}, второе число {y} -> НЕ КРАТНО, остаток {z}");
}
