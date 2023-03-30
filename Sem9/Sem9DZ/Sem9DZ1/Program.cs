// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до M.
// M = 1; N = 5. -> “5, 4, 3, 2, 1"
// M = 4; N = 8. -> “8, 7, 6, 5, 4"
Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "");
int c = 1;
if (M > N)
{
    Console.Write("Ошибка ввода! M > N!!!");
    return;
}
string result = GetNumber(M,N);
Console.WriteLine(result);

static string GetNumber(int M,int N)
{
    if (M==N)
    return N.ToString();
    else return N + ", " +  GetNumber(M, N-1);
}