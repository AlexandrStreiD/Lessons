// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите первое число диапазона рандома: ");
int min = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число диапазона рандома: ");
int max = int.Parse(Console.ReadLine() ?? "");
if (max < min)
{
    int min1 = max;
    max = min;
    min = min1;
}
int[,] array = GetArray(rows, columns, min, max);
PrintArray(array);
Console.Write("\n");
int[] array1 = DictionaryNum(array, min, max);
//PrintArray1(array1);
PrintDictionaryNum(array1, min);


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

void PrintArray1(int[] inArray)
{

    for (int j = 0; j < inArray.GetLength(0); j++)
    {
        Console.Write($"{inArray[j]} ");
    }
    Console.WriteLine();
}

void PrintDictionaryNum(int[] inArray, int min)
{

    for (int j = 0; j < inArray.GetLength(0); j++)
    {
        if (inArray[j] == 0)
        {
            min++;
        }
        else
        {
            Console.WriteLine($"{min} встречается - {inArray[j]}р ");
            min++;
        }
    }
    Console.WriteLine();
}


int[] DictionaryNum(int[,] arr, int min, int max)
{
    int num = max - min;
    int[] arr2 = new int[num + 1];
    int n;


    for (int r = 0; r < num + 1; r++)
    {
        n = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (min == arr[i, j]) n++;
            }
        }
        arr2[r] = n;
        min++;
    }
    return arr2;
}
