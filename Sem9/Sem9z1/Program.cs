// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "");
int M = 1;

string result = GetNumber(M,N);
Console.WriteLine(result);

static string GetNumber(int M,int N)
{
    if (M==N)
    return N.ToString();
    else return M + ", " +  GetNumber(M+1, N);
}
