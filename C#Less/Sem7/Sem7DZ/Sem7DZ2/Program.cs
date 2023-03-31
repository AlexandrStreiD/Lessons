// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
int[,] array = GetArray(new Random().Next(1, 11), new Random().Next(1, 11), 0, 10);
PrintArray(array);
int rows = GetNumberFromUser("Введите номер строки: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите номер столбца: ", "Ошибка ввода!");
GetFindElement(rows, columns, array);



//int len=(arr.GetLength(0)<arr.GetLength(1)) ? arr.GetLength(0):arr.GetLength(1);

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


void GetFindElement(int rows, int columns, int[,] arr)
{
    if (rows < 0 | rows > arr.GetLength(0) - 1 | columns < 0 | columns > arr.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует  ");
    }
    else
    {
         Console.WriteLine("Значение элемента массива = {0}", arr[rows, columns]);
    }
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}