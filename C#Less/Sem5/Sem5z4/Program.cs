Console.Clear();
Console.WriteLine($"Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. ");
int num = 123; //GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int[] array = GetArray(num, 0, 123);
int result = GetInd(array);


    Console.Write($"[{String.Join(", ", array)}]");
Console.Write($" -> {result}");
/*
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

static int GetInd(int[] arr)
{
    int res = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>9 && arr[i]<100 ){
            res=res+1;
        }
    }
    return res;
}

