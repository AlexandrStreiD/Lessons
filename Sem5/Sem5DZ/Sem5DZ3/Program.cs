Console.Clear();
Console.WriteLine($"Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
int num = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
double[] array = GetArray(num, 0, 100);
double max=GetMaxNumbers(array);
double min=GetMinNumbers(array);
Console.WriteLine($" Максимальный элемент -> {max}");
Console.WriteLine($" Минимальный элемент -> {min}");
double result = FindTheDifference(max, min);
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


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
static double GetMaxNumbers(double[] arr){
    double max=arr[0];
     for (int i = 0; i < arr.Length; i++)
    {
        if (max<arr[i]){
            max=arr[i];
        }
    }
    return max;
    
}
static double GetMinNumbers(double[] arr){
    double min=arr[0];
     for (int i = 0; i < arr.Length; i++)
    {
        if (min>arr[i]){
            min=arr[i];
        }
    }
    return min;
    
}


static double FindTheDifference(double max, double min)
{
    double res=max-min;
    return res;
}

