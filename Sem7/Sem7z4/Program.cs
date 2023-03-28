// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);
Console.Write("\n");
Console.Write($"Сумма диагонали равна = {FindS(array)}");
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int FindS(int[,] arr)
{
    int len=(arr.GetLength(0)<arr.GetLength(1)) ? arr.GetLength(0):arr.GetLength(1);
   /*  if (arr.GetLength(0)<arr.GetLength(1))
        len=arr.GetLength(0);
    else
        len=arr.GetLength(1);
 */
    int sum=0;
    for (int i = 0; i < len; i++)
    {
        sum += arr[i,i];     
    }
    return sum;
}



void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

