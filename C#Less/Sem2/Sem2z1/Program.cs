Console.Clear();
Console.WriteLine("\n\n\n");
Console.WriteLine("Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.");
Console.WriteLine("");
int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;
int a3 = a1*10+a2;
Console.WriteLine($"Введенное число {num} -> {a3}");