Console.Clear();
Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");

int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int[] array = new int[num];
FillArray(array);
Console.WriteLine($"[{String.Join(",", array)}]");
//PrintArray(array);


static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber>0 )
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
static int GetNumberArrayFromUser(string message, string errorMessage)
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

void FillArray(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i <lenght; i++)
    {
        array[i]=GetNumberArrayFromUser($"Введите {i+1} элемент массива: ", "Ошибка ввода!");
    }
}

void PrintArray(int[] array)
{   
    int lenght = array.Length;
    Console.Write("[");
    for (int i = 0; i <lenght; i++)
    {
        Console.Write($"{array[i]}");
        if (i!=lenght-1){
            Console.Write(",");
        }
    }
    Console.Write("]");
}