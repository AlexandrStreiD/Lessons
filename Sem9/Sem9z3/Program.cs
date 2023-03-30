// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "");

Console.Write(SumNum(N));


int SumNum(int n)
{
    int result=0;
    if (n==0) return 0;
        return SumNum(n/10)+n%10;

   
}

