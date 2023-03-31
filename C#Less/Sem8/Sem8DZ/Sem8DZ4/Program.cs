// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
Console.Write("Введите 1 элемент трехмерного массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите 2 элемент трехмерного массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите 3 элемент трехмерного массива: ");
int sloy = int.Parse(Console.ReadLine() ?? "");
int[,,] array3D = GetArray(rows, columns,sloy);
PrintArray(array3D);
Console.Write("\n");
PrintIndex(array3D);

int[,,] GetArray(int m, int n, int s)
{
    int num = new Random().Next(10, 20);
    int[,,] result = new int[m, n , s];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < s; k++)
        {
            result[i, j , k] +=num;
            num+=2;
          

        }
        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
             for (int k = 0; k < inArray.GetLength(2); k++)
        {
            Console.Write($"{inArray[i, j,k]} ");
        }}
        Console.WriteLine();
    }
}


void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}