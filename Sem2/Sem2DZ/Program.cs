Console.Clear();
Console.WriteLine("\n\n");
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine("");
Console.Write("Введите трехзначное число: ");
int z = int.Parse(Console.ReadLine() ?? "");
while (z < 99 || z > 1000)
{
    Console.WriteLine("ОШИБКА!!! ВВЕДИТЕ ЧИСЛО ОТ 100 ДО 999 ");
    Console.Write("Введите трехзначное число: ");
    z = int.Parse(Console.ReadLine() ?? "");
}
int z1=(z%100)/10;

Console.WriteLine($"{z} -> {z1}");



Console.WriteLine("\n\n");
Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("");
Console.Write("Введите число: ");
z = int.Parse(Console.ReadLine() ?? "");
z1=0;
if (z<100){
    Console.WriteLine($"{z} -> третьей цифры нет");
}
else{
    if (z>999){
        if (z<10000) {
        //z1=z/100;
            z1=z/10;
            z1=z1%10;
        
        }
        if (z<100000 && z>9999){
            z1=z/100;
            z1=z1%10;
        }
       if (z<1000000 && z>99999){
            z1=z/1000;
            z1=z1%10;
        }
        if (z<10000000 && z>999999){
            z1=z/10000;
            z1=z1%10;
        }
        if (z<100000000 && z>9999999){
            z1=z/100000;
            z1=z1%10;
        }
         if (z<1000000000 && z>99999999){
            z1=z/1000000;
            z1=z1%10;
        }
    Console.WriteLine($"{z} -> {z1}");    
    }
    else{z1=z%10;
    Console.WriteLine($"{z} -> {z1}");
    }
    
}

Console.WriteLine("\n\n");
Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.WriteLine("");
Console.Write("Введите НОМЕР дня недели: ");
z = int.Parse(Console.ReadLine() ?? "");
while (z < 1 || z > 7)
{
    Console.WriteLine("ОШИБКА!!! ВВЕДИТЕ ЧИСЛО ОТ 1 ДО 7 ");
    Console.Write("Введите номер дня недели: ");
    z = int.Parse(Console.ReadLine() ?? "");
}
if (z == 6 || z == 7)
{
    Console.WriteLine($"{z} день -> да");
}
else 
{
    Console.WriteLine($"{z} день -> нет");
}
