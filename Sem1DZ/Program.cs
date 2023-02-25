Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("");
Console.WriteLine("Введите первое целое число X: ");
int X = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе целое число Y: ");
int Y = int.Parse(Console.ReadLine() ?? "");
if (X > Y)
{
    Console.WriteLine($"{X}, {Y} => {X}");
}
else
{
    Console.WriteLine($"{X}, {Y} => {Y}");
}



Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("");
Console.WriteLine("Введите первое целое число Х1: ");
int X1 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе целое число Х2: ");
int X2 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите третье целое число Х3: ");
int X3 = int.Parse(Console.ReadLine() ?? "");
while (X1 == X2 || X2 == X3 || X1 == X3)
{
    Console.WriteLine("Ошибка!!! Введите разные числа!");
    Console.WriteLine("Введите первое целое число Х1: ");
    X1 = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите второе целое число Х2: ");
    X2 = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Введите третье целое число Х3: ");
    X3 = int.Parse(Console.ReadLine() ?? "");
}
if (X1 > X2 && X1 > X3)
{
    Console.WriteLine($"{X1}, {X2}, {X3} => {X1}");
}
if (X2 > X1 && X2 > X3)
{
    Console.WriteLine($"{X1}, {X2}, {X3} => {X2}");
}
else
{
    Console.WriteLine($"{X1}, {X2}, {X3} => {X3}");
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.WriteLine("");
Console.WriteLine("Введите число: ");
int chislo = int.Parse(Console.ReadLine() ?? "");
if (chislo % 2 == 0) Console.WriteLine($"{chislo} -> ДА");
else Console.WriteLine($"{chislo} -> НЕТ");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("");
Console.WriteLine("Введите число: ");
int chislo1 = int.Parse(Console.ReadLine() ?? "");
int i = 2;
while (chislo1<=i-1){
    Console.WriteLine("ОШИБКА! Число должно быть больше 1!");
    chislo1 = int.Parse(Console.ReadLine() ?? "");
}
Console.WriteLine($"Четные числа числа {chislo1}: ");
while(i<=chislo1){

    Console.WriteLine(i);

    i+=2;
}







/*
Console.Write("Введите первое целое число X: ");
int X = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе целое число Y: ");
int Y = int.Parse(Console.ReadLine() ?? "");
//int Chint = int.Parse(Console.ReadLine() ?? "");
int result = (int)Math.Pow(Y, 2);
if (X == result)
{
    Console.WriteLine($"x={X}, Y={Y} -> ДА ");
}
else
{
    Console.WriteLine($"x={X}, Y={Y} -> Нет"); ;
}



Console.Write("Введите НОМЕР дня недели: ");
int z = int.Parse(Console.ReadLine() ?? "");
while (z < 1 || z > 7)
{
    Console.WriteLine("ОШИБКА!!! ВВЕДИТЕ ЧИСЛО ОТ 1 ДО 7 ");
    Console.Write("Введите номер дня недели: ");
    z = int.Parse(Console.ReadLine() ?? "");
}
if (z == 1)
{
    Console.WriteLine($"{z} день -> ПОНЕДЕЛЬНИК");
}
if (z == 2)
{
    Console.WriteLine($"{z} день -> ВТОРНИК");
}
if (z == 3)
{
    Console.WriteLine($"{z} день -> СРЕДА");
}
if (z == 4)
{
    Console.WriteLine($"{z} день -> ЧЕТВЕРГ");
}
if (z == 5)
{
    Console.WriteLine($"{z} день -> ПЯТНИЦА");
}
if (z == 6)
{
    Console.WriteLine($"{z} день -> СУББОТА");
}
if (z == 7)
{
    Console.WriteLine($"{z} день -> ВОСКРЕСЕНЬЕ");
}

*/
