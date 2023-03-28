
// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Clear();
Console.Write("Введите количество строк матрицы 1: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов матрицы 1: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество строк матрицы 2: ");
int rows1 = int.Parse(Console.ReadLine() ?? "");
Console.Write(" ");
int columns1 = GetNumberFromUser("Введите количество столбцов матрицы 2: ", "Ошибка ввода!!! Число столбцов 2 матрици не равно числу строк 1 матрицы.", rows);

int[,] array = GetArray(rows, columns, 0, 10);
int[,] array1 = GetArray(rows1, columns1, 0, 10);
int[,] resultArray = new int[rows, columns1];

Console.WriteLine("Матрица 1");
PrintArray(array);
Console.WriteLine("Матрица 2");
PrintArray(array1);
MultiplyArray(array, array1, resultArray);
Console.WriteLine("Произведение");
PrintArray(resultArray);

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


void MultiplyArray(int[,] arr, int[,] arr1, int[,] resultArr)
{


    for (int i = 0; i < resultArr.GetLength(0); i++)
    {
        for (int j = 0; j < resultArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                sum += arr[i, k] * arr1[k, j];
            }
            resultArr[i, j] = sum;
        }
    }

}

int GetNumberFromUser(string message, string errorMessage, int rows)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && rows == userNumber)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
