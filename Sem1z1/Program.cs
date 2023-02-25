
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
while (z<1 || z>7) {
    Console.WriteLine("ОШИБКА!!! ВВЕДИТЕ ЧИСЛО ОТ 1 ДО 7 ");
    Console.Write("Введите номер дня недели: ");
    z = int.Parse(Console.ReadLine() ?? "");
}
if (z==1){
    Console.WriteLine($"{z} день -> ПОНЕДЕЛЬНИК");
}
if (z==2){
    Console.WriteLine($"{z} день -> ВТОРНИК");
}
if (z==3){
    Console.WriteLine($"{z} день -> СРЕДА");
}
if (z==4){
    Console.WriteLine($"{z} день -> ЧЕТВЕРГ");
}
if (z==5){
    Console.WriteLine($"{z} день -> ПЯТНИЦА");
}
if (z==6){
    Console.WriteLine($"{z} день -> СУББОТА");
}
if (z==7){
    Console.WriteLine($"{z} день -> ВОСКРЕСЕНЬЕ");
}


