//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.Write("\n");
PrintArray(SwapRows(array));

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


int [,] SwapRows(int[,] arr)
{
    int num=0;
    int leng=arr.GetLength(0)-1;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        num = arr[0, j];
        arr[0, j] = arr[leng, j];
        arr[leng, j] = num;
    }
    return arr;
}
