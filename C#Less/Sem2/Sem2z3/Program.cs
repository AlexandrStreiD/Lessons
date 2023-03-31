Console.Clear();
Console.WriteLine("\n\n\n");
Console.WriteLine("Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23");
Console.WriteLine("");
Console.WriteLine("Введите целое число X: ");
int x = int.Parse(Console.ReadLine() ?? "");
/*if ((x % 7 == 0) && (x % 23==0))
{
    Console.WriteLine($"{x} -> ДА");
}
else
{   Console.WriteLine($"{x} -> НЕТ");
}*/
bool result = (x % 7 == 0 && x % 23 == 0);
if (result)
{
    Console.WriteLine($"{x} -> ДА");
}
else
{
    Console.WriteLine($"{x} -> НЕТ");
}

