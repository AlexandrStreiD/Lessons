Console.Clear();
Console.WriteLine($"Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
int num = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = GetArray(num, 0, 100);
int result = GetSumNotEvenIndex(array);
Console.Write($"[{String.Join(", ", array)}]");
Console.Write($" -> {result}");

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
/*
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
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

static int GetSumNotEvenIndex(int[] arr)
{
    int res = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            res = res + arr[i];
        }
    }
    return res;
}

