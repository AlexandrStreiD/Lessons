//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
double [,] array = GetArray(rows, columns);
PrintArray(array);
double[,] GetArray(int m, int n)
{
    double[,] result = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * 100 -50; //new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            //Console.Write($"{ inArray[i, j]} ");
            Console.Write(" " + string.Format("{0:0.0}", inArray[i, j]));
        }
        Console.WriteLine();
    }
}

