// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
int rows = 4;

int[,] array = new int [rows, rows];
Console.Write("\n");
ArraySpiral(array);
PrintArray(array);




void ArraySpiral(int[,] arr)
{
int temp = 1;
int Chislo = new Random().Next(1, 12);
int i = 0;
int j = 0;
while (temp <= arr.GetLength(0) * arr.GetLength(1))
{

  arr[i, j] = Chislo;
  Chislo++;
  temp++;
  if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= arr.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > arr.GetLength(1) - 1)
    j--;
  else
    i--;
}
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


