Console.Clear();
Console.WriteLine("\n\n\n");
Console.WriteLine("Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.");
Console.WriteLine("");
Console.WriteLine("Введите целое число X: ");
int x = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите целое число Y: ");
int y = int.Parse(Console.ReadLine() ?? "");

bool result = (x  == y*y || y  == x*x );
if (result)
{
    Console.WriteLine($"{x}, {y} -> ДА");
}
else
{
    Console.WriteLine($"{x}, {y} -> НЕТ");
}

