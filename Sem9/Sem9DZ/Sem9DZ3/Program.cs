// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "");
Console.Write(AkcFunk(M, N));

int AkcFunk(int m, int n)
{
    if (m == 0) return n+1;
    if (m!=0 && n==0) return AkcFunk(m-1, 1);   
    if (m> 0 && n>0 ) return AkcFunk(m-1, AkcFunk(m, n-1));
    return AkcFunk(m, n);
}
