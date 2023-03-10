Console.Clear();
Console.WriteLine($"Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.");
int num = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = GetArray(num, -100, 100);

int num1 = GetNumberFromUser1("Введите целое число: ", "Ошибка ввода!");
bool resalt=GetSearch(array, num1);
if (resalt == true)
{
    Console.Write($"Число {num1}; ");

    Console.Write($"Массив [{String.Join(", ", array)}]");

    Console.Write($" -> ДА");
}
else
{    
    Console.Write($"Число {num1}; ");
    Console.Write($"Массив [{String.Join(", ", array)}]");
    Console.Write($" -> НЕТ");
}



static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

static int GetNumberFromUser1(string message, string errorMessage)
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

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

static bool GetSearch(int[] arr, int n)
{
    foreach (int el in arr)
    {
        if (el == n)
        {
            return true;
            /*Console.Write($" -> ДА");
            break;*/
        }
        /*else
        {
            Console.Write($" -> НЕТ");
            break;
        }*/
    }
    return false;
}

